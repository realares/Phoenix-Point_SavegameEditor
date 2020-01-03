using Base.Utils;
using PP_Parser.Parser;

namespace PhoenixPoint.Common.Levels.MapGeneration
{
    public class MapPlotGenerationData : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericCollection<string> Tags { get; set; }
        public UnityDateTime LocalTime { get; set; }
        public int RandomSeed { get; set; }
    }
}
