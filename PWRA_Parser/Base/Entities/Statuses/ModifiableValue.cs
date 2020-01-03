using Newtonsoft.Json;
using PP_Parser.Parser;

namespace Base.Entities.Statuses
{
    public class ModifiableValue : PhonixBaseObjectBaseValue
    {
        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double EndValue { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double BaseValue { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double ModificationValue { get; set; }

        [JsonIgnore]
        public double Value
        {
            get => EndValue; 
            set
            {
                EndValue = value;
                BaseValue = value;
            }
        }
    }
}
