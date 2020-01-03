using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Tactical.Levels.FactionEffects
{
    public class TacticalFactionEffect : PhonixBaseObjectBaseValue
    {
        public bool Applied { get; set; }
        public int TurnApplied { get; set; }
        public PhoenixObjectID BaseDef { get; set; }
    }
}
