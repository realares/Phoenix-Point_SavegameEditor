using Base;
using Base.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
