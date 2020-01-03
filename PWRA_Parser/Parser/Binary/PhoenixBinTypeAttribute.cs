using System;


namespace PP_Parser.Parser.Binary
{    

    [System.AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    sealed class PhoenixBinTypeAttribute : Attribute
    {

        readonly PhoenixTypeCode _phoenixType;
        readonly BinPropertyReflection.SerializeConverter _SerializeConverter;
        readonly BinPropertyReflection.DeserializeConverter _DeserializeConverter;

        public PhoenixBinTypeAttribute(PhoenixTypeCode phoenixType)
        {
            this._phoenixType = phoenixType;
        }
        public PhoenixBinTypeAttribute(PhoenixTypeCode phoenixType
            , BinPropertyReflection.SerializeConverter serializeConverter
            , BinPropertyReflection.DeserializeConverter deserializeConverter)
        {
            this._phoenixType = phoenixType;
            this._SerializeConverter = serializeConverter;
            this._DeserializeConverter = DeserializeConverter;
        }
        public PhoenixTypeCode PhoenixType
        {
            get { return _phoenixType; }
        }
        public BinPropertyReflection.SerializeConverter SerilizeConverter
        {
            get { return _SerializeConverter; }
        }
        public BinPropertyReflection.DeserializeConverter DeserializeConverter
        {
            get { return _DeserializeConverter; }
        }

    }

    [System.AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    sealed class CombinedNullIgnoreAttribute : Attribute
    {
        public CombinedNullIgnoreAttribute()
        {
        }

    }

}
