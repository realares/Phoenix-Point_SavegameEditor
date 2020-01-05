using PP_Parser.Parser;

namespace PhoenixPoint.Tactical.Entities.Statuses
{
    public class OffMapStatus : PhonixBaseObjectBaseValue
    {
        public int TurnApplied { get; set; }
        public bool ShouldForceViewInWaitingState { get; set; }
        public PhoenixObjectID BaseDef { get; set; }
        public PhoenixObjectID Source { get; set; }
        public bool Applied { get; set; }
        public PhoenixObjectID VehicleActorBase { get; set; }
        public int _animatorStateHash { get; set; }
    }
}

