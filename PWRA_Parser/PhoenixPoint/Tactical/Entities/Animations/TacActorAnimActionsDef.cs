using Newtonsoft.Json;
using PP_Parser.Parser;
using PP_Parser.Parser.Binary;

namespace PhoenixPoint.Tactical.Entities.Animations
{
    public class TacActorAnimActionsDef : PhoenixTagDef
    {
        [CombinedNullIgnore]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string name { get; set; }

        [CombinedNullIgnore]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public PhoenixGenericArray<PhoenixObjectID> AnimActions { get; set; }

        [CombinedNullIgnore]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string PrefabSource { get; set; }
    }
}
