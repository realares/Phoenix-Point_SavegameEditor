using PhoenixPoint.Common.Entities;
using PP_Parser.Parser;

namespace PhoenixPoint.Tactical.Entities.ActorsInstance
{
    public class TacCharacterData : PhonixBaseObjectBaseValue
    {
        public GeoTacUnitId Id { get; set; }
        public int Strength { get; set; }
        public int Will { get; set; }
        public int Speed { get; set; }
        public int CurrentHealth { get; set; }
        public int CurrentWP { get; set; }

        public PhoenixGenericCollection<PhoenixObjectID> Stats { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> Statuses { get; set; }
        public PhoenixGenericArray<PhoenixObjectID> BodypartItems { get; set; }
        public PhoenixGenericArray<PhoenixObjectID> EquipmentItems { get; set; }
        public PhoenixGenericArray<PhoenixObjectID> InventoryItems { get; set; }
        public PhoenixGenericCollection<ItemData> BodypartItemsData { get; set; }
        public PhoenixGenericCollection<ItemData> EquipmentItemsData { get; set; }
        public PhoenixGenericCollection<ItemData> InventoryItemsData { get; set; }
        public PhoenixGenericArray<PhoenixObjectID> Abilites { get; set; }
        public PhoenixObjectID LevelProgression { get; set; }
        public string Name { get; set; }
        public bool LocalizeName { get; set; }
        public PhoenixObjectID PrefabSource { get; set; }
        public PhoenixObjectID ComponentSetTemplate { get; set; }
        public PhoenixGenericArray<PhoenixObjectID> OverrideComponentDefs { get; set; }
        public PhoenixObjectID ViewElementDef { get; set; }
        public PhoenixGenericArray<PhoenixObjectID> GameTags { get; set; }

    }
}
