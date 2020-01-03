using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Levels.Objectives
{
    public class EventGeoFactionObjective : PhonixBaseObjectBaseValue
    {
        public string EventID { get; set; }
        public bool _completed { get; set; }
        public Base.UI.LocalizedTextBind Title { get; set; }
        public Base.UI.LocalizedTextBind Description { get; set; }
        public PhoenixObjectID GivenByFaction { get; set; }
    }
}
