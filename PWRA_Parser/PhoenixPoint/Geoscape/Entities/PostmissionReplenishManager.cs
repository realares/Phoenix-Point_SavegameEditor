using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Geoscape.Entities
{
    public class PostmissionReplenishManager : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericCollection<PhoenixGenericKeyValue<PhoenixObjectID, PhoenixObjectID>> _preferredLoadouts { get; set; }
        public bool FreeRestore { get; set; }

        public class Loadout : PhonixBaseObjectBaseValue
        {
            public PhoenixGenericCollection<PhoenixObjectID> _armourItems { get; set; }
            public PhoenixGenericCollection<PhoenixObjectID> _equipmentItems { get; set; }
            public PhoenixGenericCollection<PhoenixObjectID> _inventoryItems { get; set; }
        }
    }
}
