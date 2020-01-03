using Base;
using Newtonsoft.Json;
using PP_Parser.Parser;
using PP_Parser.Parser.Binary;


namespace Base.Core
{
    public class ComponentSetDef : PhoenixTagDef
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [CombinedNullIgnore]
        public string name { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [CombinedNullIgnore]
        public PhoenixGenericArray<PhoenixObjectID> Components { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [CombinedNullIgnore]
        public PhoenixObjectID PrefabSource { get; set; }
    }
}
