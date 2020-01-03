using Base.Utils;
using PP_Parser.Parser;
using PP_Parser.Parser.Binary;

namespace PhoenixPoint.Common.Core
{
    public class ResourceUnit : PhonixBaseObjectBaseValue
    {
        public PhoenixEnum Type { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double Value { get; set; }
    }
}
