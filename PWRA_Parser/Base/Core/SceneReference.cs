using Newtonsoft.Json;
using PP_Parser.Parser;

namespace Base.Core
{
    public class SceneReference : PhonixBaseObjectBaseValue
    {
        [JsonProperty("_scenePath")]
        public string ScenePath { get; set; }
    }
}
