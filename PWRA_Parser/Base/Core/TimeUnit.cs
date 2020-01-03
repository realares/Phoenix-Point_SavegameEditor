using Base.Utils;
using Newtonsoft.Json;
using PP_Parser.Parser;
using PP_Parser.Parser.BinParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Core
{
    public class TimeUnit : PhonixBaseObjectBaseValue
    {
        [JsonProperty("_time")]
        public PhoenixTimeSpan DateTime { get; set; }
    }


    public class PhoenixTimeSpan : PhonixBaseObjectBaseValue
    {
        [PhoenixBinType(PhoenixTypeCode.Long,
            BinPropertyReflection.SerializeConverter.TickToLong,
            BinPropertyReflection.DeserializeConverter.notset)]
        public PhoenixTimeSpanTicks Ticks { get; set; }
    }

    public class PhoenixTimeSpanTicks : IPhoenixTimeTicks
    {
        private TimeSpan _dt;

        [JsonProperty("_@long")]
        public string Ticks
        {
            get
            {
                return _dt.Ticks.ToString();
            }
            set
            {
                _dt = new TimeSpan(long.Parse(value));
            }
        }
    }
}
