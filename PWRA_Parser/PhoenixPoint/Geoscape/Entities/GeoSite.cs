using Base;
using Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Geoscape.Entities
{
    public class GeoSite : PhonixBaseObjectBaseValue
    {
        public ActorCreateData ActorCreateData { get; set; }

        public GeoSiteInstaceData SerializationData { get; set; }
    }
}
