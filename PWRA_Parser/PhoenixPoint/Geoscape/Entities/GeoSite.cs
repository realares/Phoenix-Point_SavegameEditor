using Base.Entities;
using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Entities
{
    public class GeoSite : PhonixBaseObjectBaseValue
    {
        public ActorCreateData ActorCreateData { get; set; }

        public GeoSiteInstaceData SerializationData { get; set; }
    }
}
