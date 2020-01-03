using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Entities
{
    public class GeoItem : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID ItemDef { get; set; }
        public PhoenixObjectID CommonItemData { get; set; }
        public PhoenixObjectID _commonItemData { get; set; }
    }
}
