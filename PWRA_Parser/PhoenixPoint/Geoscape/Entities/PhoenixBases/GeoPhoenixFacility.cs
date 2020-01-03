using Base.Core;
using Base.Utils;
using PP_Parser.Parser;
using UnityEngine.CoreModule;

namespace PhoenixPoint.Geoscape.Entities.PhoenixBases
{
    public class GeoPhoenixFacility : PhonixBaseObjectBaseValue
    {
        public PhoenixTagDef _def { get; set; }
        public Vector2Int _position { get; set; }
        public PhoenixEnum _rotation { get; set; }
        public PhoenixGenericArray<PhoenixObjectID> _components { get; set; }
        public bool _isPowered { get; set; }
        public bool IsCorridor { get; set; }
        public uint FacilityId { get; set; }
        public TimeUnit _nextUpdateTime { get; set; }
        public TimeUnit _prevUpdateTime { get; set; }
        public int _health { get; set; }
        public PhoenixEnum _state { get; set; }
    }
}
