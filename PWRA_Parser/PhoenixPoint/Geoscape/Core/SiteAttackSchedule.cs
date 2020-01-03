using Base;
using Base.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
