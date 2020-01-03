﻿using Base;

namespace PhoenixPoint.Tactical.Entities.Statuses
{
    public class BonusStatHolderStatus : PhonixBaseObjectBaseValue
    {
        public int TurnApplied { get; set; }
        public bool ShouldForceViewInWaitingState { get; set; }
        public PhoenixObjectID BaseDef { get; set; }
        public PhoenixObjectID Source { get; set; }
        public bool Applied { get; set; }
    }
}
