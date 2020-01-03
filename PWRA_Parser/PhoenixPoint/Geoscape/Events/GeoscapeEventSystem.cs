using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Events
{
    public class GeoscapeEventSystem
    {
        public class EventSystemInstanceData : PhonixBaseObjectBaseValue
        {
            public PhoenixGenericCollection<PhoenixGenericKeyValue<string,int>> CustomVariables { get; set; }
            public PhoenixGenericCollection<string> TriggeredEncounters { get; set; }

            public bool SupressEvents { get; set; }

            public int AmbushProtection { get; set; }
        }

    }

}
