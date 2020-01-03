using Base;
using Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Tactical.Levels.Destruction
{

    public class Destructable : PhonixBaseObjectBaseValue
    {
        public Base.Levels.SceneObjectIds.SceneObjectId GuidInScene { get; set; }
        public PhoenixGenericArray<PhoenixEnum> _gridStorage { get; set; }
       
    }
}
