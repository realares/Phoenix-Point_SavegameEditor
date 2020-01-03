using Base;
using Base.Utils;
using PhoenixPoint.Tactical.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Tactical.Levels
{
    public class SlidingDoor : PhonixBaseObjectBaseValue
    {
        public int DeploymentCost { get; set; }
        public bool HasEnteredPlay { get; set; }
        public Base.Entities.ActorCreateData ActorCreateData { get; set; }
        public TacActorBaseInstanceData SerializationData { get; set; }
        public int _open { get; set; }
        public PhoenixObjectID _navigatingActor { get; set; }

    }
}
