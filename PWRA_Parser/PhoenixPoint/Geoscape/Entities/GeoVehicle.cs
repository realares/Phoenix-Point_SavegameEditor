using Base;
using Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Geoscape.Entities
{
    public class GeoVehicle : PhonixBaseObjectBaseValue
    {
        public ActorCreateData ActorCreateData { get; set; }
        public PhoenixPoint.Geoscape.Entities.GeoVehicleInstanceData SerializationData { get; set; } 
    }
}
