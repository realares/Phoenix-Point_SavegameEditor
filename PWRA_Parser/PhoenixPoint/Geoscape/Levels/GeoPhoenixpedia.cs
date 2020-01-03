using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Geoscape.Levels
{
    public class GeoPhoenixpedia 
    {
        public class InstanceData : PhonixBaseObjectBaseValue
        {
            public PhoenixGenericCollection<string>  InspectedEntryIds { get; set; }

            public PhoenixGenericCollection<PhoenixObjectID> AdditionalEntries { get; set; }
        }
    }
}
