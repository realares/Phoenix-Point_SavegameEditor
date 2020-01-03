using Base;
using Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Common.Levels.MapGeneration
{
    public class MapPlotGenerationData : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericCollection<string> Tags { get; set; }
        public UnityDateTime LocalTime { get; set; }
        public int RandomSeed { get; set; }
    }
}
