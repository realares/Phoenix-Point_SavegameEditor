using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Levels.Objectives
{
    public class FindPhoenixBaseGeoFactionObjective : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID _base { get; set; }
        public Base.UI.LocalizedTextBind Title { get; set; }
        public Base.UI.LocalizedTextBind Description { get; set; }
        public PhoenixObjectID GivenByFaction { get; set; }
    }
}
