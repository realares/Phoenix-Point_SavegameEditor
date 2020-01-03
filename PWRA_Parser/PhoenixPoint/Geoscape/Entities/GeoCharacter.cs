using Base.Entities.Statuses;
using Newtonsoft.Json;
using PhoenixPoint.Common.Entities;
using PhoenixPoint.Common.Entities.Characters;
using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Entities
{
    public class GeoCharacter : PhonixBaseObjectBaseValue
    {

        public GeoTacUnitId Id { get; set; }
        public int DeploymentCost { get; set; }

        public KnownPhoenixObjectID<CharacterIdentity> _identity { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> OtherStats { get; set; }

        public PhoenixGenericCollection<KnownPhoenixObjectID<GeoItem>> _armourItems { get; set; }
        

        public PhoenixGenericCollection<KnownPhoenixObjectID<GeoItem>> _equipmentItems { get; set; }

        [JsonProperty("_inventoryItems")]
        public PhoenixGenericCollection<KnownPhoenixObjectID<GeoItem>> _inventoryItems { get; set; }

        public PhoenixGenericCollection<PhoenixObjectID> AdditionalDeploymentTags { get; set; }

        public KnownPhoenixObjectID<CharacterProgression> _progression { get; set; }

        public KnownPhoenixObjectID<StatusStat> _health { get; set; }

        public KnownPhoenixObjectID<CharacterFatigue> _fatigue { get; set; }

        public bool TemporaryUnit { get; set; }

        [JsonProperty("_id")]
        public GeoTacUnitId _id { get; set; }

        [JsonProperty("_classDef")]
        public KnownPhoenixObjectID<CharacterClassDef> _classDef { get; set; }

        [JsonProperty("_factionDef")]
        public PhoenixObjectID _factionDef { get; set; }
    }


}
