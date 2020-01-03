using Base.Utils;
using Newtonsoft.Json;
using PP_Parser.Parser;

namespace Base.Core
{
    public class NextUpdate : PhonixBaseObjectBaseValue
    {
        public TimeUnit NextTime { get; set; }

        public bool Relative { get; set; }

        [JsonProperty("_updateType")]
        public PhoenixEnum UpdateType { get; set; }
    }
}
