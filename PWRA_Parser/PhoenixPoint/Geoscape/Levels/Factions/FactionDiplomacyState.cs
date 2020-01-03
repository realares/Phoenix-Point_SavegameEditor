using Base.UI;
using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Levels.Factions
{
    public class FactionDiplomacyState : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID Relation { get; set; }
        public LocalizedTextBind Title { get; set; }
        public LocalizedTextBind Description { get; set; }
        public PhoenixObjectID PointOfInterest { get; set; }
        public bool AtWar { get; set; }
        public PhoenixObjectID AggresionMission { get; set; }
    }
}
