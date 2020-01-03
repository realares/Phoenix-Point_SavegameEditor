using Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.UI
{
    public class LocalizedTextBind : PhonixBaseObjectValue
    {
        public string LocalizationKey { get; set; }

        [JsonProperty("_doNotLocalize")]
        public bool DoNotLocalize { get; set; }
    }
}
