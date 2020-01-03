using Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Geoscape.Levels
{
    public class GeoscapeLog : PhonixBaseObjectBaseValue
    {
        [JsonProperty("_entries")]
        public PhoenixGenericCollection<PhoenixObjectID> _entries { get; set; }

        public bool LoggingEnabled { get; set; }

    }
}
