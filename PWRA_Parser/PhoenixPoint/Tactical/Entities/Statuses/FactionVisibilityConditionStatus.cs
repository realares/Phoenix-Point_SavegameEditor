using Base;
using Base.Utils;

namespace PhoenixPoint.Tactical.Entities.Statuses
{
    public class FactionVisibilityConditionStatus : PhonixBaseObjectBaseValue
    {
        public int TurnApplied { get; set; }
        public bool ShouldForceViewInWaitingState { get; set; }
        public PhoenixObjectID BaseDef { get; set; }
        public PhoenixObjectID Source { get; set; }
        public bool Applied { get; set; }
        public PhoenixEnum _currentKnownState { get; set; }
    }
}
