using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Entities.Research
{
    public class Research : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericArray<PhoenixObjectID> AllResearchesArray { get; set; }
        public PhoenixObjectID CurrentResearch { get; set; }
        public PhoenixObjectID _factionDef { get; set; }
        public bool Paused { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> _researchQueue { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> _oldResearchQueue { get; set; }
    }
}
