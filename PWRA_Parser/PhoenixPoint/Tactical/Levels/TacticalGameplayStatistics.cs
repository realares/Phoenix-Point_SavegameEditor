using Base;
using PP_Parser.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Tactical.Levels
{
    public class TacticalGameplayStatistics : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericCollection<PhoenixGenericKeyValue<PhoenixObjectID, TacticalGameplayStatistics.BodypartEvolutionStatisticsData>> _bodypartDamageStatistics { get; set; }

        public class BodypartEvolutionStatisticsData : PhonixBaseObjectBaseValue
        {
            public float Damage { get; set; }
        }
    }
}
