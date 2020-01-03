using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Geoscape.Entities
{
    public class GeoItem : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID ItemDef { get; set; }
        public PhoenixObjectID CommonItemData { get; set; }
        public PhoenixObjectID _commonItemData { get; set; }
    }
}
