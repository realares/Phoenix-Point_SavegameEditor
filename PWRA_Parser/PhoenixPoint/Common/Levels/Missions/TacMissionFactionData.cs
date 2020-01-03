using Base;
using Base.Utils;
using PP_Parser.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
