using Base;
using Newtonsoft.Json;
namespace PhoenixPoint.Common.Entities
{
    public class GeoTacUnitId : PhonixBaseObjectBaseValue
    {
        [JsonProperty("_id")]
        public int ID { get; set; }
    }
}
