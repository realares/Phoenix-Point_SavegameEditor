using Base;
using Base.Utils;

namespace PhoenixPoint.Geoscape.Entities.PhoenixBases.FacilityComponents
{
    public class AICoreFacilityComponent : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericArray<PhoenixEnum> _aiCoreSlots { get; set; }
        public PhoenixTagDef GeoFacilityComponentDef { get; set; }
    }
}
