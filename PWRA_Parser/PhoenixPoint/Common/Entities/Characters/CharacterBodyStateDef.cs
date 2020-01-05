using Newtonsoft.Json;
using PP_Parser.Parser;
using PP_Parser.Parser.Binary;

namespace PhoenixPoint.Common.Entities.Characters
{
    public class CharacterBodyStateDef : PhoenixTagDef
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [CombinedNullIgnore]
        public string name { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [CombinedNullIgnore]
        public PhoenixGenericArray<PhoenixObjectID> BodyPartsDefs { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [CombinedNullIgnore]
        public PhoenixObjectID PrefabSource { get; set; }
    }
}
