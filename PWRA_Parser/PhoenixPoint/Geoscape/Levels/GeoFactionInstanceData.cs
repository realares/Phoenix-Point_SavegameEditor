using Base;
using Base.Core;
using Newtonsoft.Json;
using PhoenixPoint.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Geoscape.Levels
{
    public class GeoFactionInstanceData : PhonixBaseObjectBaseValue
    {
        
        public PhoenixObjectID FactionDef { get; set; }
        public Wallet Wallet { get; set; }
        public PhoenixObjectID ItemStorage { get; set; }

        public NextUpdate HealRosterNextUpdate { get; set; }

        public NextUpdate GenerateRecruitsNextUpdate { get; set; }

        public PhoenixGenericCollection<PhoenixObjectID> PhoenixBaseTargets { get; set; }

        public PhoenixObjectID BuildingZone { get; set; }

        public PhoenixGenericCollection<PhoenixObjectID> GameTags { get; set; }

        public PhoenixObjectID Research { get; set; }
        public PhoenixObjectID ManufactureQueue { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> UnlockedMutations { get; set; }

        public PhoenixObjectID ExtendedInstanceData { get; set; }
        public PhoenixObjectID Diplomacy { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> Objectives { get; set; }
        public int NextFactionRequestCountdownDays { get; set; }
        public int LastVehicleIndex { get; set; }
    }
}
