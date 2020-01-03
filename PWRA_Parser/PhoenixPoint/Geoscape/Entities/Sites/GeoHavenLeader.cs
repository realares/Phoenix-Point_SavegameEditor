using Base;
using PhoenixPoint.Geoscape.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Geoscape.Entities.Sites
{
    public class GeoHavenLeader : PhonixBaseObjectBaseValue
    {
        public GeoUnitId Id { get; set; }
        public PhoenixObjectID FactionDef { get; set; }
        public PhoenixObjectID Identity { get; set; }
        public PhoenixObjectID Diplomacy { get; set; }
    }
}
