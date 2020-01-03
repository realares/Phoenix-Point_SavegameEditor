using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Levels
{
    public class GeoPhoenixpedia 
    {
        public class InstanceData : PhonixBaseObjectBaseValue
        {
            public PhoenixGenericCollection<string>  InspectedEntryIds { get; set; }

            public PhoenixGenericCollection<PhoenixObjectID> AdditionalEntries { get; set; }
        }
    }
}
