using Base.Utils;
using PP_Parser.Parser;
using UnityEngine.CoreModule;

namespace PhoenixPoint.Geoscape.Entities.PhoenixBases
{
    public class GeoPhoenixBaseLayout : PhonixBaseObjectBaseValue
    {
        public PhoenixTagDef _def { get; set; }
        public PhoenixEnum _baseEntranceSide { get; set; }
        public PhoenixGenericCollection<KnownPhoenixObjectID<GeoPhoenixFacility>> _facilities { get; set; }
        public PhoenixGenericCollection<Vector2Int> _rockTiles { get; set; }
        public uint _lastFacilityId { get; set; }

    }
}
