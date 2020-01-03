using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Common.Entities.Characters
{
    public class LevelProgression : PhonixBaseObjectBaseValue
    {
        public int Experience { get; set; }
        public LevelProgressionDef Def { get; set; }
        public bool HasNewLevel { get; set; }
    }
}
