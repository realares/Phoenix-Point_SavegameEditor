using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Entities.PhoenixBases.FacilityComponents
{
    public class VehicleSlotFacilityComponent : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericArray<PhoenixObjectID> _groundSlots { get; set; }
        public PhoenixGenericArray<PhoenixObjectID> _aircraftSlots { get; set; }
        public PhoenixTagDef GeoFacilityComponentDef { get; set; }
    }
}
