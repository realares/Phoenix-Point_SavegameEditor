using PP_Parser.Parser;

namespace PhoenixPoint.Tactical.AI
{
    public class AIBlackboardData : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericCollection<PhoenixObjectID> HighPriorityTargets { get; set; }
        public PhoenixGenericCollection<PhoenixGenericKeyValue<PhoenixObjectID, float>> AggrosByActor { get; set; }
    }
}
