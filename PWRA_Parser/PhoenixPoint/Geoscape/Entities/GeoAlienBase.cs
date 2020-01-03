using Base.Core;
using PhoenixPoint.Common.Core;
using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Entities
{
    public class GeoAlienBase
    {
        public class InstanceData : PhonixBaseObjectBaseValue
        {
            public PhoenixObjectID AlienBaseTypeDef { get; set; }
            public EarthUnits BaseExpansion { get; set; }
            public NextUpdate NextBaseExpansionUpdate { get; set; }
            public int CreatedAtEvolutionPoints { get; set; }
            public int HavenAttackCounter { get; set; }
        }
    }
}
