using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Tactical.Entities
{
    public class TacticalActor : PhonixBaseObjectBaseValue
    {
        public int DeploymentCost { get; set; }
        public bool HasEnteredPlay { get; set; }
        public Base.Entities.ActorCreateData ActorCreateData { get; set; }
        public PhoenixPoint.Tactical.Entities.TacActorInstanceData SerializationData { get; set; }
        public bool _enterPlayAbilityPlayed { get; set; }
        public PhoenixObjectID _validHulkParts { get; set; }
    }
}
