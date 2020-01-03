using Base;
using Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
