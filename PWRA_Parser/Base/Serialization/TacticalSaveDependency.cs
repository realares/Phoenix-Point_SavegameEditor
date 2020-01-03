using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Serialization
{
    public class TacticalSaveDependency : PhonixBaseObjectBaseValue
    {
        public string CorrespondingGeoscapeSave { get; set; }
        public string CorrespondingRestartSave { get; set; }
    }
}
