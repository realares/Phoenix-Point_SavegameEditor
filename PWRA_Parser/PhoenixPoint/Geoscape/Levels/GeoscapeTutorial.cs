using Base.Core;
using Base.Utils;
using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Levels
{
    public class GeoscapeTutorial
    {
        public class InstanceData : PhonixBaseObjectBaseValue
        {
            public bool Enabled { get; set; }

            public PhoenixGenericCollection<PhoenixEnum> ShownSteps { get; set; }

            public PhoenixGenericCollection<PhoenixEnum> CompletedSteps { get; set; }
            public PhoenixGenericCollection<PhoenixObjectID> FastManufactureFacilities { get; set; }
            public TimeUnit ShowDiplomacyAfter { get; set; }
            public TimeUnit ShowHavenAfter { get; set; }
            public PhoenixObjectID ScavengingSite { get; set; }
            public int Version { get; set; }

        }
    }
}
