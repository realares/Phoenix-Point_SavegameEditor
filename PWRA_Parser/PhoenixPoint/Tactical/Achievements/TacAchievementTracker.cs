using PP_Parser.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Tactical.Achievements
{
    public class TacAchievementTracker
    {
        public class TacActorKillStats : PhonixBaseObjectBaseValue
        {
            public int Kills { get; set; }
            public PhoenixObjectID Actor { get; set; }

        }
    }
}
