using Newtonsoft.Json;
using PP_Parser.Parser;

namespace Base.UI
{
    public class LocalizedTextBind : PhonixBaseObjectValue
    {
        public string LocalizationKey { get; set; }

        [JsonProperty("_doNotLocalize")]
        public bool DoNotLocalize { get; set; }
    }
}
