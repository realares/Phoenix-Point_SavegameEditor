using Base;
using Base.Utils;
using PP_Parser.Parser;

namespace PhoenixPoint.Common.Entities.Characters
{
    public class TacticalMissionUnitHistoryItem : PhonixBaseObjectBaseValue
    {
        public int TurnNumber { get; set; }
        public string ActorSceneName { get; set; }
        public string ActorDisplayName { get; set; }
        public PhoenixObjectID WeaponDef { get; set; }
        public PhoenixObjectID AbilityDef { get; set; }
        public PhoenixEnum Type { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double Points { get; set; }
    }
}
