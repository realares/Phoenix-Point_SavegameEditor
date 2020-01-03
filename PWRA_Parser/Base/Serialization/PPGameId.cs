using Newtonsoft.Json;
using PP_Parser.Parser;

namespace Base.Serialization
{
    public class PPGameId : PhonixBaseObjectBaseValue
    {
        public int GameStartedIndex { get; set; }

        [JsonProperty("_guidString")]
        public string GuidString { get; set; }
    }
}
