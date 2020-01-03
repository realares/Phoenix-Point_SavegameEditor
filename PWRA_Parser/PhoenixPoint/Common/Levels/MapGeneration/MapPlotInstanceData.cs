using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Common.Levels.MapGeneration
{
    public class MapPlotInstanceData : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID MapPlotDef { get; set; }
        public PhoenixGenericCollection<MapParcelInstance> ParcelInstances { get; set; }
    }
}
