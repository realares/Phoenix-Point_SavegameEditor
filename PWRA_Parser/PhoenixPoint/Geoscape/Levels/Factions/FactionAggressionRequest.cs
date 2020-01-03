using Base.UI;
using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Levels.Factions
{
    public class FactionAggressionRequest : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID AgainstFaction { get; set; }
        public PhoenixObjectID FromFaction { get; set; }

        public PhoenixTagDef AgainstZoneType { get; set; }
        public bool Accepted { get; set; }
        public LocalizedTextBind Description { get; set; }
        public LocalizedTextBind Summary { get; set; }
        public PhoenixObjectID ResourcesReward { get; set; }
        public int FactionDiplomacyReward { get; set; }
    }
}
