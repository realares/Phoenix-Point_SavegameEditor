using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Tactical.Levels.ActorDeployment
{
    public class MissionDeployCondition : PhonixBaseObjectBaseValue
    {
        public MissionDeployConditionData MissionData { get; set; }
        public PhoenixObjectID DeployZone { get; set; }


    }
}
