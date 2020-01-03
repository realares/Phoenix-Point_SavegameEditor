using Base;
using Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Entities.Statuses
{
    public class StatusStat : PhonixBaseObjectBaseValue
    {
        public ModifiableValue Min { get; set; }
        public ModifiableValue Max { get; set; }
        public string Name { get; set; }
        public ModifiableValue Value { get; set; }
        public PhoenixGenericCollection<StatModification> Modifications { get; set; }
        public PhoenixEnum _roundingMode { get; set; }
    }
}
