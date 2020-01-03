using Base.Utils;
using PP_Parser.Parser;
using PP_Parser.Parser.Binary;

namespace PhoenixPoint.Common.Levels.Missions
{
    public class TacMissionFactionData : PhonixBaseObjectBaseValue
    {
        public PhoenixEnum ParticipantKind { get; set; }
        public PhoenixObjectID FactionDef { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> ActorDeployData { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> ActorModifierEffects { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double ExperienceMultiplier { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double InitialDeploymentPoints { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double ReinforcementDeploymentPoints { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double ReinforcementDeltaPerTurn { get; set; }
    }
}
