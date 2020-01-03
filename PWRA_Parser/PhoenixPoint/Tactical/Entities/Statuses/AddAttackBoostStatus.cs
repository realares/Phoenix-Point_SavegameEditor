using Base;

namespace PhoenixPoint.Tactical.Entities.Statuses
{
    public class AddAttackBoostStatus : PhonixBaseObjectBaseValue
    {
        public int TurnApplied { get; set; }
        public bool ShouldForceViewInWaitingState { get; set; }
        public PhoenixObjectID BaseDef { get; set; }
        public PhoenixObjectID Source { get; set; }
        public bool Applied { get; set; }
        public int _attacksBoosted { get; set; }
    }
}
