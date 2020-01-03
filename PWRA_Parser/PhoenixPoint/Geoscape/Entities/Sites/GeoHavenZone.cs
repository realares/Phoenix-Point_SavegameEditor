using Base.Utils;
using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Entities.Sites
{
    public class GeoHavenZone : PhonixBaseObjectBaseValue
    {
        public PhoenixTagDef Def { get; set; }
        public int ZoneCount { get; set; }
        public PhoenixEnum _state { get; set; }
        public PhoenixObjectID Health { get; set; }
    }
}
