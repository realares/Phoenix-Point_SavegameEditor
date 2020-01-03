using Base;
using Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Tactical.Levels
{
    public class TacLevelInstanceData : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID CurrentFactionDef { get; set; }
        public PhoenixGenericCollection<PhoenixPoint.Tactical.Levels.TacFactionData> Factions { get; set; }
        public PhoenixObjectID TacMission { get; set; }
        public PhoenixObjectID GameplayStatistics { get; set; }
        public PhoenixObjectID AchievementData { get; set; }

    }
}
