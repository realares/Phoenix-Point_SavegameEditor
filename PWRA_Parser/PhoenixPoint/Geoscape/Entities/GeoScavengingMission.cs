using Base.Utils;
using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Entities
{
    public class GeoScavengingMission : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID Site { get; set; }
        public UnityDateTime GlobalTime { get; set; }
        public PhoenixObjectID MissionDef { get; set; }
        public PhoenixObjectID _enemyFaction { get; set; }
        public PhoenixObjectID _squad { get; set; }
        public PhoenixEnum _threatLevel { get; set; }
    }
}
