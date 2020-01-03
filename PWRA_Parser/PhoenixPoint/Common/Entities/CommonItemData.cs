using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Common.Entities
{
    public class CommonItemData : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID OwnerItem { get; set; }
        public PhoenixObjectID Ammo { get; set; }
        public int _charges { get; set; }
        public int _count { get; set; }
    }
}
