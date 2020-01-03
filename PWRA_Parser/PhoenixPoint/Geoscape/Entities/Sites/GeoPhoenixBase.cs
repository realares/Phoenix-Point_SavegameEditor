using Base;
using Base.UI;
using PhoenixPoint.Common.Core;
using PhoenixPoint.Geoscape.Entities.PhoenixBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Geoscape.Entities.Sites
{
    public class GeoPhoenixBase
    {
        public class InstanceData : PhonixBaseObjectBaseValue
        {
            public KnownPhoenixObjectID<GeoPhoenixBaseLayout> Layout { get; set; }
            public EarthUnits MistRepellerRange { get; set; }
            public bool AutoAssignEnabled { get; set; }
            public LocalizedTextBind LocationDescription { get; set; }
        }
    }
}
