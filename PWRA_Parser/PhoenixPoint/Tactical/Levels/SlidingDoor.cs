using PhoenixPoint.Tactical.Entities;
using PP_Parser.Parser;

namespace PhoenixPoint.Tactical.Levels
{
    public class SlidingDoor : PhonixBaseObjectBaseValue
    {
        public int DeploymentCost { get; set; }
        public bool HasEnteredPlay { get; set; }
        public Base.Entities.ActorCreateData ActorCreateData { get; set; }
        public TacActorBaseInstanceData SerializationData { get; set; }
        public int _open { get; set; }
        public PhoenixObjectID _navigatingActor { get; set; }

    }
}
