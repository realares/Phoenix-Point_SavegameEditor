using Base;
using Base.Levels.SceneObjectIds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Common.Levels.MapGeneration
{
    public class MapParcelInstance : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID MapParcelDef { get; set; }
        public float RotationDegrees { get; set; }
        public SceneObjectId MapParcelPositionId { get; set; }
        
    }
}
