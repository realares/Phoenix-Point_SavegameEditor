using Newtonsoft.Json;
using PP_Parser.Parser;
using PP_Parser.Parser.Binary;

namespace PhoenixPoint.Common.Levels.Missions
{
    public class TacMissionDef : PhoenixTagDef
    {
        [CombinedNullIgnore]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string name { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [CombinedNullIgnore]
        public PhoenixObjectID MissionData { get; set; }


    }
}
