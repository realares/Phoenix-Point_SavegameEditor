using Base;
using Base.Core;
using Base.Utils;
using PhoenixPoint.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Geoscape.Entities
{
    public class GeoHaven
    {
        public class InstanceData : PhonixBaseObjectBaseValue
        {
            public NextUpdate NextleaderDiplomacyUpdate { get; set; }
            public int Population { get; set; }
            public PhoenixObjectID Leader { get; set; }
            public PhoenixObjectID Recruit { get; set; }
            public bool RecruitChecked { get; set; }
            public PhoenixGenericCollection<PhoenixObjectID> Zones { get; set; }
            public EarthUnits MistRepellerRange{ get; set; }
            public PhoenixObjectID OfferedResources { get; set; }
            public PhoenixEnum AlertLevel { get; set; }
            public int AlertLevelCooldown { get; set; }
            public int AlienAttackImmunityCounter { get; set; }
            public PhoenixObjectID EnvironmentTag { get; set; }
        }
    }
}
