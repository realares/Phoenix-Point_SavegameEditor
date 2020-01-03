using Base;
using Base.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Common.Core
{
    public class Wallet : PhonixBaseObjectBaseValue
    {
        [JsonProperty("_resources")]
        public PhoenixGenericCollection<KeyValue_ResourceUnit> Resources { get; set; }
    }

    public class KeyValue_ResourceUnit : PhonixBaseObjectBaseValue
    {
        public PhoenixEnum Key { get; set; }
        public ResourceUnit Value { get; set; }
    }
}
