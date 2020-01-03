using Base.Utils;
using PP_Parser.Parser;

namespace PhoenixPoint.Tactical.Entities.ActorsInstance
{
    public class TacEquipmentCrateData : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericArray<PhoenixObjectID> Items { get; set; }
        public RangeDataInt Quantity { get; set; }
        public string Name { get; set; }
        public bool LocalizeName { get; set; }
        public PhoenixTagDef PrefabSource { get; set; }
        public PhoenixObjectID ComponentSetTemplate { get; set; }
        public PhoenixGenericArray<PhoenixObjectID> OverrideComponentDefs { get; set; }
        public PhoenixTagDef ViewElementDef { get; set; }
        
        public PhoenixGenericArray<PhoenixObjectID> GameTags { get; set; }
    }
}
