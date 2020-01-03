using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Common.Entities
{
    public class AmmoManager : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericCollection<PhoenixObjectID> LoadedMagazines { get; set; }
        public PhoenixObjectID ParentItem { get; set; }
    }
}
