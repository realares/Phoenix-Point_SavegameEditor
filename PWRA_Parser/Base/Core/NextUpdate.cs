using Base;
using Base.Core;
using Base.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Core
{
    public class NextUpdate : PhonixBaseObjectBaseValue
    {
        public TimeUnit NextTime { get; set; }

        public bool Relative { get; set; }

        [JsonProperty("_updateType")]
        public PhoenixEnum UpdateType { get; set; }
    }
}
