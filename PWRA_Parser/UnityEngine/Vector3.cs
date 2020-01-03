﻿using Newtonsoft.Json;
using PP_Parser.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine.CoreModule
{
    public class Vector3
    {
        [JsonProperty("#Type")]
        public int _Type { get; set; }

        [JsonProperty("x")]
        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double X { get; set; }

        [JsonProperty("y")]
        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double Y { get; set; }

        [JsonProperty("z")]
        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double Z { get; set; }
    }

    
}