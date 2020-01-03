using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
