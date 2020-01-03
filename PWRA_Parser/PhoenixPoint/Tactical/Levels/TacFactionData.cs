using Base.Utils;
using PP_Parser.Parser;
using PP_Parser.Parser.Binary;

namespace PhoenixPoint.Tactical.Levels
{
    public class TacFactionData : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID FactionDef { get; set; }
        public int TurnNumber { get; set; }
        public PhoenixGenericCollection<PhoenixGenericKeyValue<PhoenixObjectID, PhoenixPoint.Tactical.Levels.TacticalFactionVision.KnownCounters>> KnownActors { get; set; }

        public PhoenixGenericCollection<PhoenixGenericKeyValue<PhoenixObjectID, PhoenixEnum>> Relations { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> FactionEffects { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double ExperienceMultiplier { get; set; }
        public PhoenixPoint.Tactical.AI.AIBlackboardData AIBlackboardData { get; set; }

    }
}
