using Newtonsoft.Json;
using PhoenixPoint.Common.Entities;
using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Entities
{
    public class GeoAlienMutationClass : PhonixBaseObjectBaseValue
    {
        public GeoTacUnitId Id { get; set; }


        public int DeploymentCost { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> _bodyParts { get; set; }

        [JsonProperty("Equipment")]
        public PhoenixGenericCollection<PhoenixObjectID> Equipment { get; set; }

        [JsonProperty("TemporaryUnit")]
        public bool TemporaryUnit { get; set; }

        [JsonProperty("_id")]
        public GeoTacUnitId _Id { get; set; }

        [JsonProperty("_classDef")]
        public PhoenixObjectID _classDef { get; set; }

        [JsonProperty("_factionDef")]
        public PhoenixObjectID _factionDef { get; set; }

    }
}
