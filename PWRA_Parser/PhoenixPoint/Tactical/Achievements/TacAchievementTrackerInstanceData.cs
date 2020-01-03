using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Tactical.Achievements
{
    public class TacAchievementTrackerInstanceData : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericCollection<PhoenixObjectID> KillStats { get; set; }
        public int Turn { get; set; }
    }
}
