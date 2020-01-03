using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Entities.PhoenixBases.FacilityComponents
{
    public class UseSoldiersFacilityComponent : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericArray<PhoenixObjectID> _workerSlotsArray { get; set; }
        public PhoenixGenericArray<PhoenixObjectID> _userSlotsArray { get; set; }
        public PhoenixTagDef GeoFacilityComponentDef { get; set; }
    }
}
