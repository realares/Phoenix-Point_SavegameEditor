using Base.Entities;
using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Entities
{
    public class GeoVehicle : PhonixBaseObjectBaseValue
    {
        public ActorCreateData ActorCreateData { get; set; }
        public PhoenixPoint.Geoscape.Entities.GeoVehicleInstanceData SerializationData { get; set; } 
    }
}
