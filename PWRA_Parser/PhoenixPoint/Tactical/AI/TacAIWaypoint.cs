﻿using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Tactical.AI
{
    public class TacAIWaypoint : PhonixBaseObjectBaseValue
    {
        public int DeploymentCost { get; set; }
        public bool HasEnteredPlay { get; set; }
        public Base.Entities.ActorCreateData ActorCreateData { get; set; }
        public PhoenixPoint.Tactical.Entities.TacActorBaseInstanceData SerializationData { get; set; }
    }
}
