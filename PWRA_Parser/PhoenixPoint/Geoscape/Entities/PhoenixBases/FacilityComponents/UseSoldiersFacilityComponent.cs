using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Geoscape.Entities.PhoenixBases.FacilityComponents
{
    public class UseSoldiersFacilityComponent : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericArray<PhoenixObjectID> _workerSlotsArray { get; set; }
        public PhoenixGenericArray<PhoenixObjectID> _userSlotsArray { get; set; }
        public PhoenixTagDef GeoFacilityComponentDef { get; set; }
    }
}
