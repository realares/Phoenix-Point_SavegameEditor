using PP_Parser.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Geoscape.Entities
{
    public class GeoSquad : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericCollection<PhoenixObjectID> Units { get; set; }
    }
}
