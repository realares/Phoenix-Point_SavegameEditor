using Base.Entities.Statuses;
using PhoenixPoint.Common.Entities;
using PhoenixPoint.Common.Entities.Characters;
using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Entities
{
    public class GeoTacUnit : PhonixBaseObjectBaseValue
    {
        public GeoTacUnitId Id { get; set; }
        public int DeploymentCost { get; set; }
        public GeoTacUnitId _id { get; set; }

        public bool TemporaryUnit { get; set; }
        public KnownPhoenixObjectID<CharacterClassDef> _classDef { get; set; }

        public PhoenixObjectID _factionDef { get; set; }
    }
}
