using Base.Utils;
using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Entities.Research
{
    public class ResearchElement : PhonixBaseObjectBaseValue
    {
        public bool IsInProgress { get; set; }
        public PhoenixEnum _state { get; set; }
        public string ResearchID { get; set; }
        public float ResearchProgress { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> _serializableRevealRequirementsData { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> _serializableUnlockRequirementsData { get; set; }
    }
}
