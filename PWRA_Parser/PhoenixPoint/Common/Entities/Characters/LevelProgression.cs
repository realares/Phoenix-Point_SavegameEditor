using PP_Parser.Parser;

namespace PhoenixPoint.Common.Entities.Characters
{
    public class LevelProgression : PhonixBaseObjectBaseValue
    {
        public int Experience { get; set; }
        public LevelProgressionDef Def { get; set; }
        public bool HasNewLevel { get; set; }
    }
}
