using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Tactical.Levels.Destruction
{
    public class Breakable : PhonixBaseObjectBaseValue
    {
        public Base.Levels.SceneObjectIds.SceneObjectId GuidInScene { get; set; }
        public bool _broken { get; set; }
    }
}
