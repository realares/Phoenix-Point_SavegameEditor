using Base.Utils;
using PP_Parser.Parser;

namespace PhoenixPoint.Tactical.Levels
{
    public class TacticalFactionVision
    {
        public class KnownCounters : PhonixBaseObjectBaseValue
        {
            public PhoenixGenericCollection<PhoenixGenericKeyValue<PhoenixEnum, int>> _counters { get; set; }
        }
    }
}
