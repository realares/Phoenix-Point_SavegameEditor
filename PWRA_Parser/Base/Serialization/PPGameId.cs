using Newtonsoft.Json;

namespace Base.Serialization
{
    public class PPGameId : PhonixBaseObjectBaseValue
    {
        public int GameStartedIndex { get; set; }

        [JsonProperty("_guidString")]
        public string GuidString { get; set; }
    }
}
