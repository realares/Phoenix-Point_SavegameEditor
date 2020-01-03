using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Entities
{
    public class GeoLevelSavegame
    {
        public class Data : PhonixBaseObjectBaseValue
        {
            public PhoenixObjectID LevelInstanceData { get; set; }

            public PhoenixGenericCollection<GeoActor> Actors { get; set; }
        }
    }
}
