using Base.Core;
using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Entities
{
    public class VehicleFactionController
    {
        public class InstanceData : PhonixBaseObjectBaseValue
        {
            public NextUpdate WaitingUpdateTime { get; set; }
            public PhoenixObjectID LastVisitedSite { get; set; }
            public PhoenixObjectID WaitForSiteMission { get; set; }
        }
    }
}
