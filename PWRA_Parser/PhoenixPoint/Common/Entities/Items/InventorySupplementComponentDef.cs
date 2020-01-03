using Newtonsoft.Json;
using PP_Parser.Parser;
using PP_Parser.Parser.Binary;

namespace PhoenixPoint.Common.Entities.Items
{
    public class InventorySupplementComponentDef : PhoenixTagDef
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [CombinedNullIgnore]
        public string name { get; set; }

        //[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        //[CombinedNullIgnore]
        //public PhoenixGenericArray<PhoenixObjectID> Components { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [CombinedNullIgnore]
        public PhoenixObjectID PrefabSource { get; set; }

        public class ItemChancePair : PhonixBaseObjectBaseValue
        {
            public int ChanceToPresent { get; set; }
            public PhoenixObjectID ItemDef { get; set; }
        }
    }

}
