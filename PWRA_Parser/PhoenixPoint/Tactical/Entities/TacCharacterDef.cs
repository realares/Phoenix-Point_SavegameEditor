using Newtonsoft.Json;
using PP_Parser.Parser;

namespace PhoenixPoint.Tactical.Entities
{
    public class TacCharacterDef : PhoenixTagDef
    {
        [JsonProperty(NullValueHandling =NullValueHandling.Ignore)]
        [PP_Parser.Parser.Binary.CombinedNullIgnore]
        public string name { get; set; }
    }
    

}
