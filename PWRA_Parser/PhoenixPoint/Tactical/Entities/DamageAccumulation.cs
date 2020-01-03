using Base;
using PP_Parser.Parser;

namespace PhoenixPoint.Tactical.Entities
{
    public class DamageAccumulation : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID DamageEffectDef { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double Amount { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double ActorMultiplier { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double BodyPartMultiplier { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double ObjectMultiplier { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double ArmorPiercing { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double ArmorShred { get; set; }
        public PhoenixObjectID DamageTypeDef { get; set; }
        public PhoenixObjectID Source { get; set; }
        public PhoenixObjectID SourceActor { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double InitialAmount { get; set; }
        public PhoenixObjectID DamageKeywords { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double SourceMultiplier { get; set; }
        public bool Attenuating { get; set; }
    }
}
