using PP_Parser.Parser;
using PP_Parser.Parser.Binary;

namespace PhoenixPoint.Tactical.Entities.Equipments
{
    public class ItemContainer : PhonixBaseObjectBaseValue
    {
        public int DeploymentCost { get; set; }
        public bool HasEnteredPlay { get; set; }
        public Base.Entities.ActorCreateData ActorCreateData { get; set; }

        [DynamicReflect]
        public PhonixBaseObjectBaseValue2 SerializationData { get; set; }
        //public PhoenixPoint.Tactical.Entities.Equipments.ItemContainerInstanceData SerializationData { get; set; }

    }
}
