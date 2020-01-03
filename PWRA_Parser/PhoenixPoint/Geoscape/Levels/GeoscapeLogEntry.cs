using Base;
using Base.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Geoscape.Levels
{
    public class GeoscapeLogEntry : PhonixBaseObjectBaseValue
    {
        public Base.UI.LocalizedTextBind Text { get; set; }
        public PhoenixGenericArray<Base.UI.LocalizedTextBind> Parameters { get; set; }
        public TimeUnit EventDate { get; set; }
        public bool HighPriority { get; set; }
    }
}
