using Base;
using Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Geoscape.Entities.Sites
{
    public class GeoHavenZone : PhonixBaseObjectBaseValue
    {
        public PhoenixTagDef Def { get; set; }
        public int ZoneCount { get; set; }
        public PhoenixEnum _state { get; set; }
        public PhoenixObjectID Health { get; set; }
    }
}
