using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Tactical.Levels.ActorDeployment
{
    public class MissionDeployConditionData : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID ActorTagDef { get; set; }
        public bool ExcludeActor { get; set; }
        public int ActivateOnTurn { get; set; }
        public int DeactivateAfterTurn { get; set; }
    }
}
