using PP_Parser.Parser;

namespace PhoenixPoint.Common.Entities
{
    public class AmmoManager : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericCollection<PhoenixObjectID> LoadedMagazines { get; set; }
        public PhoenixObjectID ParentItem { get; set; }
    }
}
