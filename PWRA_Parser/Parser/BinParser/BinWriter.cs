﻿using Base;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Parser.Parser.BinParser
{
    public class BinWriter
    {
        Dictionary<string, int> _stringTable = new Dictionary<string, int>();

        public void Write(object saveGame)
        {
            string path = @"g:\test\writertest.sav";
            if (File.Exists(path))
                File.Delete(path);
            using (var writeStream = File.OpenWrite(path))
            {

                using (BinaryWriter _writer = new BinaryWriter(writeStream))
                {
                    _writer.Write((UInt32)PP_Parser.BinParser.BinConsts.HeaderMagic);

                    WriteObject(saveGame, _writer);

                    var stringtablelist  = _stringTable.Keys.ToList<string>();

                    WriteArrayObject<string>(stringtablelist, _writer);
                }
            }
        }

        public void WriteObject(object obj, BinaryWriter writer)
        {
            using (var obj_stream = new MemoryStream())
            {
                using (var obj_writer = new BinaryWriter(obj_stream))
                {
                    WriteObjectProperties(obj, obj_writer);
                    byte[] data = obj_stream.ToArray();

                    writer.Write((byte)PhoenixTypeCode.Object);
                    writer.Write((Int32)data.Length + 4);
                    writer.Write(obj_stream.ToArray());
                }
            }
        }

        public void WriteObjectProperties(object obj, BinaryWriter writer)
        {
            //if (obj)

            var type = obj.GetType();
            var props = ReflectionMaster.Instance.ReflectProperties(type);

            bool gloalNullIgnore = false;
            if (props.Any(x => x.CombinedNullIgnore))
            {
                gloalNullIgnore = true;
                foreach (var prop in props)
                {
                    if (!prop.CombinedNullIgnore) continue;

                    if (prop.Property.GetValue(obj) != null)
                    {
                        gloalNullIgnore = false;
                        break;
                    }
                }
            }

            foreach (var prop in props)
            {
                if (gloalNullIgnore && prop.CombinedNullIgnore)
                    continue;

                WritePropertyName(prop, writer);
                WritePropertyValue(prop, obj, writer);
            }
        }

        public void WriteArrayObject<T>(List<T> obj, BinaryWriter writer)
        {
            var type = obj.GetType();
            var genType = type.GetGenericArguments().Single();

            PhoenixTypeCode phoenixType = ReflectionMaster.GetPhoenixTypeCode(genType);


            using (var obj_stream = new MemoryStream())
            {
                using (var obj_writer = new BinaryWriter(obj_stream))
                {
                    foreach (var item in obj)
                    {
                        WritePropertyValue(item, phoenixType, obj_writer);
                    }

                    byte[] data = obj_stream.ToArray();

                    writer.Write((byte)PhoenixTypeCode.Array);
                    writer.Write((Int32)data.Length + 4);
                    writer.Write(data);
                }
            }

        }


        public void WritePropertyName(BinPropertyReflection prop, BinaryWriter writer)
        {
            int key;
            if (!_stringTable.TryGetValue(prop.SerializeName, out key))
            {
                key = _stringTable.Count;
                _stringTable.Add(prop.SerializeName, key);
            }

            writer.Write((byte)PhoenixTypeCode.StringRef);
            //if (key == 0x1a)
            //{

            //}
            writer.Write((Int32)key);

        }

        public void WritePropertyValue(BinPropertyReflection prop, object instance, BinaryWriter writer)
        {
            object value = prop.Property.GetValue(instance);
            if (prop.SerializeCast != null)
            {
                value = prop.SerializeCast(value);
            }
                            

            WritePropertyValue(value, prop.PhoenixValueType, writer);
        }
        public void WritePropertyValue(object value, PhoenixTypeCode phoenixType,  BinaryWriter writer)
        {
   
            if (value == null)
            {
                writer.Write((byte)PhoenixTypeCode.Empty);
                return;
            }

            switch (phoenixType)
            {
                case PhoenixTypeCode.Array:
                case PhoenixTypeCode.Object:
                    break;
                case PhoenixTypeCode.Double:
                    writer.Write((byte)PhoenixTypeCode.Float);
                    break;
                default:
                    writer.Write((byte)phoenixType);
                    break;
            }
            switch (phoenixType)
            {
                case PhoenixTypeCode.Invalid:
                    throw new Exception();
                case PhoenixTypeCode.Empty:
                    throw new Exception();
                case PhoenixTypeCode.Bool:
                    writer.Write((bool)value);
                    break;
                case PhoenixTypeCode.Byte:
                    writer.Write((byte)value);
                    break;
                case PhoenixTypeCode.Sbyte:
                    writer.Write((sbyte)value);
                    break;
                case PhoenixTypeCode.Char:
                    writer.Write((char)value);
                    break;
                case PhoenixTypeCode.Short:
                    writer.Write((short)value);
                    break;
                case PhoenixTypeCode.Ushort:
                    writer.Write((ushort)value);
                    break;
                case PhoenixTypeCode.Int:
                    writer.Write((Int32)value);
                    break;
                case PhoenixTypeCode.Uint:
                    writer.Write((UInt32)value);
                    break;
                case PhoenixTypeCode.Long:
                    writer.Write((long)value);
                    break;
                case PhoenixTypeCode.Ulong:
                    writer.Write((ulong)value);
                    break;
                case PhoenixTypeCode.Float:
                    writer.Write((float)value);
                    break;
                case PhoenixTypeCode.Double:
                    writer.Write((float)(double)value);
                    break;
                case PhoenixTypeCode.StringRef:
                    //writer.Write((Int32)4 + 4);
                    writer.Write((Int32)value);
                    break;
                case PhoenixTypeCode.StringVal:
                    {
                        string s = (string)value;

                        //if (s.Length < 200)
                        //{
                        //    writer.Write((Int32)4 + data.Length +1);
                        //}
                        using (var obj_stream = new MemoryStream())
                        {
                            using (var obj_writer = new BinaryWriter(obj_stream))
                            {
                                obj_writer.Write((string)s);
                                byte[] data = obj_stream.ToArray(); 
                                writer.Write((Int32)4 + data.Length);
                                writer.Write((string)s);
                            }
                        }                    
                    }
                    break;
                case PhoenixTypeCode.Array:

                    Type type1 = value.GetType();

                    if (type1.IsGenericType)    // List<XYZ>
                    {
                        var mi = typeof(BinWriter).GetMethod("WriteArrayObject");

                        var tg = type1.GetGenericArguments().Single();
                        var fooRef = mi.MakeGenericMethod(tg);
                        fooRef.Invoke(this, new object[] { value, writer });
                    }

                    //using (var obj_stream = new MemoryStream())
                    //{
                    //    using (var obj_writer = new BinaryWriter(obj_stream))
                    //    {
                    //        WriteObjectProperties(value, obj_writer);
                    //        writer.Write(obj_stream.ToArray());
                    //    }
                    //}
                    break;
                case PhoenixTypeCode.Object:

                    WriteObject(value, writer);
                    //using (var obj_stream = new MemoryStream())
                    //{
                    //    using (var obj_writer = new BinaryWriter(obj_stream))
                    //    {
                    //        WriteObjectProperties(value, obj_writer);
                    //        writer.Write(obj_stream.ToArray());
                    //    }
                    //}

                    break;
                default:
                    break;
            }
        }


    }
}