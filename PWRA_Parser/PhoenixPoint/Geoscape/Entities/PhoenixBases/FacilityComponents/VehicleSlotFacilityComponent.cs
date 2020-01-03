using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Geoscape.Entities.PhoenixBases.FacilityComponents
{
    public class VehicleSlotFacilityComponent : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericArray<PhoenixObjectID> _groundSlots { get; set; }
        public PhoenixGenericArray<PhoenixObjectID> _aircraftSlots { get; set; }
        public PhoenixTagDef GeoFacilityComponentDef { get; set; }
    }
}
