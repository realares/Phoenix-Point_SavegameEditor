using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Tactical.Levels.Mist
{
    public class TacticalVoxelMatrix : PhonixBaseObjectBaseValue
    {
        public bool HadMist { get; set; }

        public bool HadGoo { get; set; }

        public PhoenixGenericArray<PhoenixObjectID> _voxels { get; set; }
    }
}
