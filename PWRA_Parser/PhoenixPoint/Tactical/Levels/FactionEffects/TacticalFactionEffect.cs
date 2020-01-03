using PP_Parser.Parser;

namespace PhoenixPoint.Tactical.Levels.FactionEffects
{
    public class TacticalFactionEffect : PhonixBaseObjectBaseValue
    {
        public bool Applied { get; set; }
        public int TurnApplied { get; set; }
        public PhoenixObjectID BaseDef { get; set; }
    }
}
