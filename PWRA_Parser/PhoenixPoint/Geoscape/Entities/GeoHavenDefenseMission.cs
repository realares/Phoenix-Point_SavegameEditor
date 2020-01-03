using Base;
using Base.Core;
using Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Geoscape.Entities
{
    public class GeoHavenDefenseMission : PhonixBaseObjectBaseValue
    {
        public GeoHavenDefenseMissionInstanceData InstanceData { get; set; }
        public PhoenixObjectID Site { get; set; }
        public UnityDateTime GlobalTime { get; set; }
        public PhoenixObjectID MissionDef { get; set; }
        public PhoenixObjectID AttackerFaction { get; set; }
        public NextUpdate SerializedNextUpdate { get; set; }
        public PhoenixObjectID _squad { get; set; }
        public PhoenixEnum _threatLevel { get; set; }
    }
}
