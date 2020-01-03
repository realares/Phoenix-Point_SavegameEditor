using Base.Utils;
using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Levels.Objectives
{
    public class ActiveSitesGeoFactionObjective : PhonixBaseObjectBaseValue
    {
        public PhoenixEnum SiteType { get; set; }
        public PhoenixObjectID InspectedByFaction { get; set; }
        public Base.UI.LocalizedTextBind Title { get; set; }
        public Base.UI.LocalizedTextBind Description { get; set; }
        public PhoenixObjectID GivenByFaction { get; set; }
    }
}
