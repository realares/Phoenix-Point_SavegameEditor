using Base.Core;
using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Core
{
    public class SiteAttackSchedule : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID Site { get; set; }
        public int Counter { get; set; }
        public NextUpdate NextUpdateAttack { get; set; }
        public TimeUnit ScheduledAt { get; set; }
        public PhoenixObjectID Attacker { get; set; }
    }
}
