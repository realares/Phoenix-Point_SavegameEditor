using Base;

namespace PhoenixPoint.Tactical.Entities
{
    public class ItemData : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID ItemDef { get; set; }

        public int Charges { get; set; }
        public float Health { get; set; }
        public float Armor { get; set; }
        public PhoenixGenericCollection<ItemData> Ammo { get; set; }

        public PhoenixGenericCollection<PhoenixObjectID> OwnTags { get; set; }
    }
}