using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Geoscape
{
    public class MistRendererSystem
    {
        public class MistRendererInstanceData : PhonixBaseObjectBaseValue
        {
            public string MistData { get; set; }
            public string RepellerData { get; set; }
            public int HoursPassed { get; set; }
            public PhoenixGenericCollection<PhoenixObjectID> ActiveMistGenerators { get; set; }
        }
    }
}
