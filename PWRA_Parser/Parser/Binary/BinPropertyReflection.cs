using Base.Core;
using System;

namespace PP_Parser.Parser.Binary
{
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

