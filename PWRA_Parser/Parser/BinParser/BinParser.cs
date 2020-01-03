using Base;
using Base.Core;
using Base.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PP_Parser.Base.Lite;
using PP_Parser.Parser;
using PP_Parser.Parser.BinParser;
using PP_Parser.Parser.JsonParser;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PP_Parser.BinParser
{
    public class BinParser
    {
        #region Singleton
        private static Lazy<BinParser> _Instance = new Lazy<BinParser>(() => new BinParser());
        public static BinParser Instance = _Instance.Value;

        private BinParser() { }
        #endregion


        BinaryReader _reader;
        long _position;
        Dictionary<int, string> _stringTable = new Dictionary<int, string>();

        public void Load(string path)
        {
            using (var fs = File.OpenRead(path))
                Load(fs);
        }

        public void Load(Stream stream)
        {
            SubTyper.Instance.Clear();
            _reader = new BinaryReader(stream);
            _stringTable.Clear();

            var magic = _reader.ReadUInt32();
            if (magic != PP_Parser.BinParser.BinConsts.HeaderMagic)
                return;

            long startPosition = 4L;

            var typeSize = ReadTypeAndSize(startPosition);
            if (typeSize.Size < 0) throw new Exception();
            var FirstObjectStartPosition = _reader.BaseStream.Position;

            _position = startPosition + (long)typeSize.Size + 5L;

            
            var typeSize2 = ReadTypeAndSize(_position);
            var TypeSectionStart = _reader.BaseStream.Position;
            int i = 0;

            // read StringTable
            while (_reader.BaseStream.Position< _reader.BaseStream.Length)
            {
                var ltypeSize = ReadTypeAndSize(_reader.BaseStream.Position);
                string s2 = _reader.ReadString();
                _stringTable.Add(i++, s2);
            }

            _reader.BaseStream.Position = FirstObjectStartPosition;

            var o = ReadObjectAs<SaveMetaGame>(FirstObjectStartPosition, typeSize);

            if (o.Contents != null)
                foreach (var type in o.Contents?.Types)
                    SubTyper.Instance.AddMapping(type);

            if (o.Metadata != null)
                foreach (var type in o.Metadata?.Types)
                    SubTyper.Instance.AddMapping(type);

            if (o.RuntimeDefs != null)
                foreach (var type in o.RuntimeDefs?.Types)
                    SubTyper.Instance.AddMapping(type);


            _reader.BaseStream.Position = FirstObjectStartPosition;


            var o2 = ReadObjectAs<SaveGame>(FirstObjectStartPosition, typeSize);
            SaveGame.Instance = o2;
        }

        public T ReadObjectAs<T>(long position,  TypeSize typeSize) 
        {
            var startposition = position;
            var endposition = position + typeSize.Size;


            var props = ReflectionMaster.Instance.ReflectProperties(typeof(T));

            T instance = Activator.CreateInstance<T>();

            _reader.BaseStream.Position = startposition;

            while (_reader.BaseStream.Position < endposition)
            {
                TypeSize value_typeSize;
                object objectvalue;

                if (typeSize.Type != PhoenixTypeCode.Object)
                {
                    objectvalue = ReadObjectValue(typeSize, null, typeSize.Type);
                    return (T)objectvalue;
                }
                string parameterName = ReadPropertyName();

                value_typeSize = ReadTypeAndSize(_reader.BaseStream.Position);

                //if (!_name2Prop.TryGetValue(parameterName, out System.Reflection.PropertyInfo property))
                var propInfo = props.Find(x => x.SerializeName == parameterName);
                if (propInfo == null || propInfo.PhoenixValueType == PhoenixTypeCode.Invalid)
                {
                    _reader.BaseStream.Position += value_typeSize.Size;
                    continue;
                }

                // Special Case
                if (parameterName == "Ticks")
                {
                    if (propInfo.Property.PropertyType.Name == "PhoenixDataTimeTicks")
                    {
                        var tmp = new PhoenixDataTimeTicks();
                        tmp.Ticks = ((long)ReadObjectValue(value_typeSize, propInfo.Property, PhoenixTypeCode.Long)).ToString();
                        propInfo.Property.SetValue(instance, tmp);
                        continue;
                    }
                    else if (propInfo.Property.PropertyType.Name == "PhoenixTimeSpanTicks")
                    {
                        var tmp = new PhoenixTimeSpanTicks();
                        tmp.Ticks = ((long)ReadObjectValue(value_typeSize, propInfo.Property, PhoenixTypeCode.Long)).ToString();
                        propInfo.Property.SetValue(instance, tmp);
                        continue;
                    }
                }


                if (propInfo.PhoenixValueType != value_typeSize.Type)
                {
                    if (value_typeSize.Type == PhoenixTypeCode.Empty)
                        continue;
                    throw new Exception();
                }

                objectvalue = ReadObjectValue(value_typeSize, propInfo.Property, propInfo.PhoenixValueType);

                if (propInfo.DeserializeCast != null)
                    propInfo.Property.SetValue(instance, propInfo.DeserializeCast(objectvalue));
                else
                    propInfo.Property.SetValue(instance, objectvalue);
            }

            return instance;
        }

        private string ReadPropertyName()
        {
            var desc_typeSize = ReadTypeAndSize(_reader.BaseStream.Position);
            if (desc_typeSize.Type != PhoenixTypeCode.StringRef)
            {
                throw new Exception();
            }

            var parameterName = (string)ReadObjectValue(desc_typeSize, null, desc_typeSize.Type);
            return parameterName;
        }

        private object ReadObjectValue(TypeSize value_typeSize, PropertyInfo property, PhoenixTypeCode typecode)
        {
            object objectvalue = null;
            switch (typecode)
            {
                case PhoenixTypeCode.Invalid:
                    objectvalue = null;
                    break;
                case PhoenixTypeCode.Empty:
                    objectvalue = null;
                    break;
                case PhoenixTypeCode.Bool:
                    objectvalue = _reader.ReadBoolean();
                    break;
                case PhoenixTypeCode.Byte:
                    objectvalue = _reader.ReadByte();
                    break;
                case PhoenixTypeCode.Sbyte:
                    objectvalue = _reader.ReadSByte();
                    break;
                case PhoenixTypeCode.Char:
                    objectvalue = _reader.ReadChar();
                    break;
                case PhoenixTypeCode.Short:
                    objectvalue = _reader.ReadInt16();
                    break;
                case PhoenixTypeCode.Ushort:
                    objectvalue = _reader.ReadUInt16();
                    break;
                case PhoenixTypeCode.Int:
                    objectvalue = _reader.ReadInt32();
                    break;
                case PhoenixTypeCode.Uint:
                    objectvalue = _reader.ReadUInt32();
                    break;
                case PhoenixTypeCode.Long:
                    objectvalue = _reader.ReadInt64();
                    break;
                case PhoenixTypeCode.Ulong:
                    objectvalue = _reader.ReadUInt64();
                    break;
                case PhoenixTypeCode.Float:
                    objectvalue = _reader.ReadSingle();
                    break;
                case PhoenixTypeCode.Double:
                    objectvalue = _reader.ReadDouble();
                    break;
                case PhoenixTypeCode.StringRef:
                    {
                        int id = _reader.ReadInt32();
                        objectvalue = _stringTable[id];
                    }
                    break;
                case PhoenixTypeCode.StringVal:
                    objectvalue = _reader.ReadString();
                    break;
                case PhoenixTypeCode.Array:
                    {

                        if (property.PropertyType.IsGenericType)    // List<XYZ>
                        {
                            var mi = typeof(BinParser).GetMethod("ReadArrayObjectAs");
                            var tg = property.PropertyType.GetGenericArguments().Single();
                            var fooRef = mi.MakeGenericMethod(property.PropertyType, tg);
                            objectvalue = fooRef.Invoke(this, new object[] { _reader.BaseStream.Position, value_typeSize });
                        }
                        else  // Arraytype[]
                        {
                            throw new Exception("Can not read arrays");
                        }
                    }
                    break;
                case PhoenixTypeCode.Object:
                    {
                        if (property.Name == "ObjectValue")
                        {

                        }
                        var dynattribute = property.GetCustomAttributes(typeof(DynamicReflectAttribute), false);
                        bool isDynamic = dynattribute != null && dynattribute.Length > 0;

                        Type type2Use = property.PropertyType;
                        if (isDynamic)
                        {
                            long currentPostion = _reader.BaseStream.Position;
                            var mi = typeof(BinParser).GetMethod("ReadDynamicType");
                            var fooRef = mi.MakeGenericMethod(property.PropertyType);
                            Type newtype = (Type)fooRef.Invoke(this, new object[] { _reader.BaseStream.Position, value_typeSize });

                            if (newtype != null)
                                type2Use = newtype;

                            _reader.BaseStream.Position = currentPostion;
                        }
                        {
                            var mi = typeof(BinParser).GetMethod("ReadObjectAs");
                            var fooRef = mi.MakeGenericMethod(type2Use);
                            objectvalue = fooRef.Invoke(this, new object[] { _reader.BaseStream.Position, value_typeSize });
                        }
                    }
                    break;
                default:
                    objectvalue = null;
                    break;
            }

            return objectvalue;
        }

        public T ReadArrayObjectAs<T, G>(long position, TypeSize typeSize)
        {
            var startposition = position;
            var endposition = position + typeSize.Size;

            _reader.BaseStream.Position = startposition;

            T instance = Activator.CreateInstance<T>();

            var tt = typeof(T);

            while (_reader.BaseStream.Position < endposition)
            {
                var desc_typeSize = ReadTypeAndSize(_reader.BaseStream.Position);

                object objectvalue;

                if (desc_typeSize.Type == PhoenixTypeCode.Object
                    || desc_typeSize.Type == PhoenixTypeCode.Array)
                {
                    objectvalue = ReadObjectAs<G>(_reader.BaseStream.Position, desc_typeSize);
                }
                else
                {
                    objectvalue = ReadObjectValue(desc_typeSize, null, desc_typeSize.Type);

                    if (desc_typeSize.Type == PhoenixTypeCode.Float)
                    {
                        var proptype = ReflectionMaster.GetPhoenixTypeCode(typeof(G));
                        if (proptype == PhoenixTypeCode.Double)
                        {
                            ((ICollection<double>)instance).Add((double)(float)objectvalue);
                            continue;
                        }
                    }
                }

                if (tt.GetInterface("ICollection`1") != null)
                {
                    ((ICollection<G>)instance).Add((G)objectvalue);
                }
                
            }

            return instance;

        }

        public Type ReadDynamicType<T>(long position, TypeSize typeSize) 
        {
            var startposition = position;
            var endposition = position + typeSize.Size;

            var typproperty = FindPropertyByName<T>("#Type");

            if (typproperty == null)
                throw new Exception();

            var propname = ReadPropertyName();

            if (propname != "#Type")
                throw new Exception();

            var value_typeSize = ReadTypeAndSize(_reader.BaseStream.Position);
            var obj = ReadObjectValue(value_typeSize, null, value_typeSize.Type);

            if (obj == null || !(obj is Int32))
                throw new Exception();

            if (!SubTyper.Instance.TryGetValue((int)obj, out Type type))
                throw new Exception();

            return type;
        }

        private PropertyInfo FindPropertyByName<T>(string propname)
        {
            var propertys = typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            
            foreach (var prop in propertys)
            {
                var attributes = prop.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes != null & attributes.Length > 0)
                {
                    var attribut = (attributes[0] as JsonPropertyAttribute);
                    if (attribut.PropertyName == propname)
                        return prop;
                }
                else
                {
                    if (prop.Name == propname)
                        return prop;
                }
            }
            return null;
        }

        private TypeSize ReadTypeAndSize(long position)
        {
            _reader.BaseStream.Position = position;

            var l_valueType = (PhoenixTypeCode)_reader.ReadByte();
            var l_valueSize = GetValueSize(l_valueType);
            if (l_valueSize < 0)
            {
                // Size in File = Size(object.Length) + Size(object) 
                l_valueSize = _reader.ReadInt32() - 4;
            }
            return new TypeSize(l_valueType, l_valueSize);
        }

        public struct TypeSize
        {
            public PhoenixTypeCode Type;
            public int Size;

            public TypeSize(PhoenixTypeCode type,int size)
            {
                Type = type;
                Size = size;
            }
        }

        public static int GetValueSize(PhoenixTypeCode valType)
        {
            switch (valType)
            {
                case PhoenixTypeCode.Empty:
                    return 0;
                case PhoenixTypeCode.Bool:
                case PhoenixTypeCode.Byte:
                case PhoenixTypeCode.Sbyte:
                    return 1;
                case PhoenixTypeCode.Char:
                case PhoenixTypeCode.Short:
                case PhoenixTypeCode.Ushort:
                    return 2;
                case PhoenixTypeCode.Int:
                case PhoenixTypeCode.Uint:
                case PhoenixTypeCode.Float:
                case PhoenixTypeCode.StringRef:
                    return 4;
                case PhoenixTypeCode.Long:
                case PhoenixTypeCode.Ulong:
                case PhoenixTypeCode.Double:
                    return 8;
                default:
                    return -1;
            }
        }



    }
}
