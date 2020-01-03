using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape
{
    public class MistRendererSystem
    {
        public class MistRendererInstanceData : PhonixBaseObjectBaseValue
        {
            public string MistData { get; set; }
            public string RepellerData { get; set; }
            public int HoursPassed { get; set; }
            public PhoenixGenericCollection<PhoenixObjectID> ActiveMistGenerators { get; set; }
        }
    }
}
