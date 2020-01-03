using Newtonsoft.Json;
using PP_Parser.Parser;

namespace UnityEngine.CoreModule
{
    public class Quaternion
    {
        [JsonProperty("#Type")]
        public int _Type { get; set; }


        [JsonProperty("x")]
        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double X { get; set; }

        [JsonProperty("y")]
        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double Y { get; set; }

        [JsonProperty("z")]
        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double Z { get; set; }

        [JsonProperty("w")]
        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double W { get; set; }

    }
}
