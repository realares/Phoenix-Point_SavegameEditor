using Base;
using Base.Utils;
using PP_Parser.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Common.Core
{
    public class ResourceUnit : PhonixBaseObjectBaseValue
    {
        public PhoenixEnum Type { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double Value { get; set; }
    }
}
