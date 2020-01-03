using Newtonsoft.Json;
using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Levels
{
    public class GeoscapeLog : PhonixBaseObjectBaseValue
    {
        [JsonProperty("_entries")]
        public PhoenixGenericCollection<PhoenixObjectID> _entries { get; set; }

        public bool LoggingEnabled { get; set; }

    }
}
