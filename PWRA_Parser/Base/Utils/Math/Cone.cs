using PP_Parser.Parser;
using PP_Parser.Parser.Binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Utils.Math
{
    public class Cone : PhonixBaseObjectBaseValue
    {
        public UnityEngine.CoreModule.Vector3 Tip { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double Height { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double Radius { get; set; }
        public UnityEngine.CoreModule.Vector3 _forward { get; set; }
    }
}
