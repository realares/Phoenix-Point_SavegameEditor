using Base.Core;
using PP_Parser.Parser;
using PP_Parser.Parser.Binary;
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
