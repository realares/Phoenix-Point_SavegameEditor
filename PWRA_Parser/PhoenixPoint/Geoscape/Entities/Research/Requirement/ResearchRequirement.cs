using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Entities.Research.Requirement
{
    public class ResearchRequirement
    {
        public class InstanceData : PhonixBaseObjectBaseValue
        {
            public string ResearchRequirementDefName { get; set; }
            public int Progress { get; set; }
        }
    }
}
