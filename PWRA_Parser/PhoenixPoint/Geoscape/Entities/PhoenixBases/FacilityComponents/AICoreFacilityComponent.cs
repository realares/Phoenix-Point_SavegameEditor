using Base.Utils;
using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Entities.PhoenixBases.FacilityComponents
{
    public class AICoreFacilityComponent : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericArray<PhoenixEnum> _aiCoreSlots { get; set; }
        public PhoenixTagDef GeoFacilityComponentDef { get; set; }
    }
}
