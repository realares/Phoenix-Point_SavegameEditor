using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Tactical.Levels.Missions
{
    public class TacMission : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID BaseDef { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> ParticipantSpawns { get; set; }
        public Base.Levels.SceneObjectIds.SceneObjectId DeploymentSetId { get; set; }
    }
    
}
