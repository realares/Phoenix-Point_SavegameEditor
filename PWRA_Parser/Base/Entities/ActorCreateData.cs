using Base;
using Base.Levels.SceneObjectIds;
using PP_Parser.Parser;

namespace Base.Entities
{
    public class ActorCreateData : PhonixBaseObjectBaseValue
    {
        public SceneObjectId IdInScene { get; set; }

        public  string Name { get; set; }

        public PhoenixObjectID ActorSetDef { get; set; }
    }
}
