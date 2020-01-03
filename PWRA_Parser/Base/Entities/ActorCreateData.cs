using Base;
using Base.Levels.SceneObjectIds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Entities
{
    public class ActorCreateData : PhonixBaseObjectBaseValue
    {
        public SceneObjectId IdInScene { get; set; }

        public  string Name { get; set; }

        public PhoenixObjectID ActorSetDef { get; set; }
    }
}
