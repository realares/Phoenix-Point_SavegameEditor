using Newtonsoft.Json;
using PP_Parser.Parser;

namespace PhoenixPoint.Common.Entities
{
    public class GeoTacUnitId : PhonixBaseObjectBaseValue
    {
        [JsonProperty("_id")]
        public int ID { get; set; }
    }
}
