using Base.Core;
using Base.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Parser.Parser.BinParser
{
    public class ReflectionMaster
    {
        #region Singleton

        private static Lazy<ReflectionMaster> _Instance = new Lazy<ReflectionMaster>(() => new ReflectionMaster());
        public static ReflectionMaster Instance = _Instance.Value;
        private ReflectionMaster() 
        {
            _cache = new Dictionary<Type, List<BinPropertyReflection>>();
        }

        #endregion

        Dictionary<Type, List<BinPropertyReflection>> _cache;

        public List<BinPropertyReflection> ReflectProperties(Type baseType)
        {
            if (_cache.TryGetValue(baseType, out List<BinPropertyReflection> c))
                return c;

            List<BinPropertyReflection> result = new List<BinPropertyReflection>();

            var propertys = baseType.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
           // Dictionary<string, System.Reflection.PropertyInfo> _name2Prop = new Dictionary<string, System.Reflection.PropertyInfo>();

            int i = 0;
            bool reorderd = false;
            foreach (var prop in propertys)
            {
                // Check Ignore
                var attributes = prop.GetCustomAttributes(typeof(JsonIgnoreAttribute), false);
                if (attributes != null & attributes.Length > 0)
                    continue;

                BinPropertyReflection reflection = new BinPropertyReflection()
                {
                    Index = i++,
                    Property = prop
                    
                };


                // Check Rename and Sorting
                attributes = prop.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes != null & attributes.Length > 0)
                {
                    var attribut = (attributes[0] as JsonPropertyAttribute);
                    if (attribut.PropertyName != null)
                        reflection.SerializeName = attribut.PropertyName;
                    else
                        reflection.SerializeName = prop.Name;

                    if (attribut.Order != 0)
                    {
                        reflection.Index = attribut.Order;
                        reorderd = true;
                    }
                }
                else
                {
                    reflection.SerializeName = prop.Name;
                }


                attributes = prop.GetCustomAttributes(typeof(PhoenixBinTypeAttribute), false);
                if (attributes != null & attributes.Length > 0)
                {
                    var attribut = (attributes[0] as PhoenixBinTypeAttribute);
                    reflection.PhoenixValueType = attribut.PhoenixType;
                    
                    switch (attribut.DeserializeConverter)
                    {
                        case BinPropertyReflection.DeserializeConverter.FloatDoubleTransform:
                            reflection.DeserializeCast = BinPropertyReflection.FloatDoubleTransform;
                            break;
                        default:
                            break;
                    }

                    if (attribut.PhoenixType == PhoenixTypeCode.Float)
                    {
                        reflection.DeserializeCast = BinPropertyReflection.FloatDoubleTransform;
                        reflection.SerializeCast = BinPropertyReflection.DoubleFloatTransform;
                    }

                    switch (attribut.SerilizeConverter)
                    {

                        case BinPropertyReflection.SerializeConverter.TickToLong:
                            reflection.SerializeCast = BinPropertyReflection.TickToLong;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    reflection.PhoenixValueType = GetPhoenixTypeCode(prop.PropertyType);
                }

                attributes = prop.GetCustomAttributes(typeof(CombinedNullIgnoreAttribute), false);
                if (attributes != null & attributes.Length > 0)
                {
                    reflection.CombinedNullIgnore = true;

                }
                               
                result.Add(reflection);
            }

            if (reorderd)
                result = result.OrderBy(x => x.Index).ToList();

            _cache.Add(baseType, result);

            return result;
        }


        public static PhoenixTypeCode GetPhoenixTypeCode(Type PropertyType)
        {
            if (PropertyType.GetInterface("ICollection") != null)
                return PhoenixTypeCode.Array;

            var typecode = (TypeCode)Type.GetTypeCode(PropertyType);
            switch (typecode)
            {
                case TypeCode.Empty:
                    return PhoenixTypeCode.Empty;
                case TypeCode.Object:
                    return PhoenixTypeCode.Object;
                case TypeCode.DBNull:
                    return PhoenixTypeCode.Empty;
                case TypeCode.Boolean:
                    return PhoenixTypeCode.Bool;
                case TypeCode.Char:
                    return PhoenixTypeCode.Char;
                case TypeCode.SByte:
                    return PhoenixTypeCode.Sbyte;
                case TypeCode.Byte:
                    return PhoenixTypeCode.Byte;
                case TypeCode.Int16:
                    return PhoenixTypeCode.Short;
                case TypeCode.UInt16:
                    return PhoenixTypeCode.Ushort;
                case TypeCode.Int32:
                    return PhoenixTypeCode.Int;
                case TypeCode.UInt32:
                    return PhoenixTypeCode.Uint;
                case TypeCode.Int64:
                    return PhoenixTypeCode.Long;
                case TypeCode.UInt64:
                    return PhoenixTypeCode.Ulong;
                case TypeCode.Single:
                    return PhoenixTypeCode.Float;
                case TypeCode.Double:
                    return PhoenixTypeCode.Double;
                case TypeCode.Decimal:
                    return PhoenixTypeCode.Double;
                case TypeCode.DateTime:
                    return PhoenixTypeCode.Object;
                case TypeCode.String:
                    return PhoenixTypeCode.StringVal;
                default:
                    return PhoenixTypeCode.Empty;
            }
        }

    }

    public class BinPropertyReflection
    {
        public System.Reflection.PropertyInfo Property { get; set; }
        public int Index { get; set; }
        public string SerializeName { get; set; }
        public PhoenixTypeCode PhoenixValueType { get; set; }
        public Func<object, object> DeserializeCast { get; set; }
        public Func<object, object> SerializeCast { get; set; }
        public bool CombinedNullIgnore { get; set; }

        public enum DeserializeConverter
        {
            notset,
            FloatDoubleTransform
        }
        public enum SerializeConverter
        {
            notset,
            TickToLong
        }

        public static Func<object, object> FloatDoubleTransform => (val) =>
        {
            return (double)(float)val;
        };

        public static Func<object, object> DoubleFloatTransform => (val) =>
        {
            return (float)(double)val;
        };

        public static Func<object, object> TickToLong => (val) =>
        {
            // i know ... lame
            if (val is IPhoenixTimeTicks)
            {
                return long.Parse((val as IPhoenixTimeTicks).Ticks);
            }
            return 0L;
        };
    }
}

