using Base.Utils;
using PP_Parser.Parser;
using PP_Parser.Parser.Binary;

namespace Base.Entities.Statuses
{
    public class StatModification : PhonixBaseObjectBaseValue
    {
        public PhoenixEnum Modification { get; set; }
        public string StatName { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double Value { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double _applicationValue { get; set; }
        public PhoenixObjectID _source { get; set; }
    }
}
