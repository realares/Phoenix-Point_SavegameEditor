using Newtonsoft.Json;
using PP_Parser.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Core
{
    public class SceneReference : PhonixBaseObjectBaseValue
    {
        [JsonProperty("_scenePath")]
        public string ScenePath { get; set; }
    }
}
