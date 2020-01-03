using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Tactical.Levels.ActorDeployment
{
    public class TacticalDeployZone : PhonixBaseObjectBaseValue
    {
        public int DeploymentCost { get; set; }
        public bool HasEnteredPlay { get; set; }
        public Base.Entities.ActorCreateData ActorCreateData { get; set; }
        public PhoenixObjectID SerializationData { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> _deployConditions { get; set; }
    }
}
