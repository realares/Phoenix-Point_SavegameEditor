using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Tactical.AI
{
    public class AIBlackboardData : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericCollection<PhoenixObjectID> HighPriorityTargets { get; set; }
        public PhoenixGenericCollection<PhoenixGenericKeyValue<PhoenixObjectID, float>> AggrosByActor { get; set; }
    }
}
