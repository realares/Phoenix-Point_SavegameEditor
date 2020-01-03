using Base;
using Base.Core;
using Base.Utils;
using PP_Parser.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.CoreModule;

namespace PhoenixPoint.Geoscape.Entities
{
    public class GeoVehicleInstanceData : PhonixBaseObjectBaseValue
    {
        public Vector3 SurfacePos { get; set; }

        public Quaternion SurfaceRot { get; set; }

        public PhoenixObjectID Owner { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double RangeRemaining { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double MaintenancePoints { get; set; }

        public PhoenixObjectID CurrentSite { get; set; }

        public PhoenixGenericCollection<PhoenixObjectID> DestinationSites { get; set; }
        public bool Travelling { get; set; }

        public PhoenixGenericCollection<PhoenixObjectID> TacUnits { get; set; }
        public Base.Core.TimeUnit NextScheduledRepairTime { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double MaintenancePointsToRepair { get; set; }
        public int VehicleID { get; set; }
        public TimeUnit StartExplorationTime { get; set; }
        public NextUpdate NextSiteExplorationUpdate { get; set; }
        public PhoenixObjectID VehicleControllerInstanceData { get; set; }
        public bool OverrideTransform { get; set; }
        public Vector3 Pos { get; set; }
        public Quaternion Rot { get; set; }
        public PhoenixObjectID Source { get; set; }
        public PhoenixObjectID TimingData { get; set; }
    }
}
