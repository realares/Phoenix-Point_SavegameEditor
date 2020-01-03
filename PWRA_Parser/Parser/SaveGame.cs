using Newtonsoft.Json;

namespace PP_Parser.Parser
{
    public class SaveGame
    {
        [JsonIgnore]
        public static SaveGame Instance { get; set; }


        public int Version { get; set; }
        public PhoenixObjectHolder Metadata { get; set; }
        public PhoenixObjectHolder Contents { get; set; }
        public PhoenixObjectHolder RuntimeDefs { get; set; }

    }
}
