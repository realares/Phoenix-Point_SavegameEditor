using PhoenixPoint.Geoscape.Core;
using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Entities.Sites
{
    public class GeoHavenLeader : PhonixBaseObjectBaseValue
    {
        public GeoUnitId Id { get; set; }
        public PhoenixObjectID FactionDef { get; set; }
        public PhoenixObjectID Identity { get; set; }
        public PhoenixObjectID Diplomacy { get; set; }
    }
}
