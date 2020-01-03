using Base.Core;
using Newtonsoft.Json;
using PP_Parser.Parser;
using PP_Parser.Parser.BinParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Utils
{
    public class UnityDateTime : PhonixBaseObjectBaseValue
    {
        [JsonProperty("dateTime")]
        public PhoenixDataTime DateTime { get; set; }
    }

    public class PhoenixDataTime : PhonixBaseObjectBaseValue
    {

        public PhoenixEnum Kind { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Long, 
            BinPropertyReflection.SerializeConverter.TickToLong, 
            BinPropertyReflection.DeserializeConverter.notset)]
        public PhoenixDataTimeTicks Ticks { get; set; }
    }
    public class PhoenixDataTimeTicks: IPhoenixTimeTicks
    {
        private DateTime _dt;

        [JsonProperty("_@long")]
        public string Ticks
        {
            get
            {
                return _dt.Ticks.ToString();
            }
            set
            {
                _dt = new DateTime(long.Parse(value));
            }
        }
    }
}
