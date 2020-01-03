using PP_Parser.Parser;

namespace PhoenixPoint.Tactical.Entities.Equipments
{
    public class ItemContainer : PhonixBaseObjectBaseValue
    {
        public int DeploymentCost { get; set; }
        public bool HasEnteredPlay { get; set; }
        public Base.Entities.ActorCreateData ActorCreateData { get; set; }
        public PhoenixPoint.Tactical.Entities.Equipments.ItemContainerInstanceData SerializationData { get; set; }

    }
}
