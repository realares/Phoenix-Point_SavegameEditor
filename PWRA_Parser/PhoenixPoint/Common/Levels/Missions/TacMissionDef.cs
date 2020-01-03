using Base;
using Newtonsoft.Json;
using PP_Parser.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
