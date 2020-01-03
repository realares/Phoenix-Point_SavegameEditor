using PP_Parser.Parser;

namespace PhoenixPoint.Tactical.Entities
{
    public class CrateItemContainer : PhonixBaseObjectBaseValue
    {
        public int DeploymentCost { get; set; }
        public bool HasEnteredPlay { get; set; }
        public Base.Entities.ActorCreateData ActorCreateData { get; set; }
        public CrateItemContainerInstanceData SerializationData { get; set; }
    }
}
