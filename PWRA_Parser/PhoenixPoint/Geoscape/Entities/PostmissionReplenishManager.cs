using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Entities
{
    public class PostmissionReplenishManager : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericCollection<PhoenixGenericKeyValue<PhoenixObjectID, PhoenixObjectID>> _preferredLoadouts { get; set; }
        public bool FreeRestore { get; set; }

        public class Loadout : PhonixBaseObjectBaseValue
        {
            public PhoenixGenericCollection<PhoenixObjectID> _armourItems { get; set; }
            public PhoenixGenericCollection<PhoenixObjectID> _equipmentItems { get; set; }
            public PhoenixGenericCollection<PhoenixObjectID> _inventoryItems { get; set; }
        }
    }
}
