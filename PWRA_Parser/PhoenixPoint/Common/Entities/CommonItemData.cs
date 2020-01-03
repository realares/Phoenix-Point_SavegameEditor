using PP_Parser.Parser;

namespace PhoenixPoint.Common.Entities
{
    public class CommonItemData : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID OwnerItem { get; set; }
        public PhoenixObjectID Ammo { get; set; }
        public int _charges { get; set; }
        public int _count { get; set; }
    }
}
