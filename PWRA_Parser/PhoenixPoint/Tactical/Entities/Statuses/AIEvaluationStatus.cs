﻿using Base;

namespace PhoenixPoint.Tactical.Entities.Statuses
{
    public class AIEvaluationStatus : PhonixBaseObjectBaseValue
    {
        public int TurnApplied { get; set; }
        public bool ShouldForceViewInWaitingState { get; set; }
        public PhoenixObjectID BaseDef { get; set; }
        public PhoenixObjectID Source { get; set; }
        public bool Applied { get; set; }
        public bool _executedThisTurn { get; set; }
    }

}
