using Base;
using Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
