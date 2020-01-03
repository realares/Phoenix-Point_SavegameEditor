using Newtonsoft.Json;
using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Entities
{
    public class ItemStorage : PhonixBaseObjectBaseValue
    {
        [JsonProperty("_storageItems")]
        public PhoenixGenericCollection<PhoenixGenericKeyValue<PhoenixObjectID, PhoenixObjectID>> _storageItems { get; set; }

        [JsonProperty("_isFactionStorage")]
        public bool _isFactionStorage { get; set; }
    }
}
