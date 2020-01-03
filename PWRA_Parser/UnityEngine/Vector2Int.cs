using Newtonsoft.Json;

namespace UnityEngine.CoreModule
{
    public class Vector2Int
    {
        [JsonProperty("#Type")]
        public int _Type { get; set; }

        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }

    }

    
}
