using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Entities.Sites
{
    public class GeoSiteFactionData : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID Faction { get; set; }

        public PhoenixObjectID _faction { get; set; }
        public bool Visible { get; set; }
        public bool Inspected { get; set; }
        public bool Visited { get; set; }
    }
}
