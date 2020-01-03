using Base;
using Base.Entities.Statuses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Common.Entities.Characters
{
    public class CharacterFatigue : PhonixBaseObjectBaseValue
    {
        public KnownPhoenixObjectID<StatusStat> _stamina { get; set; }
        public PhoenixTagDef _sheetDef { get; set; }
        public int _hunger { get; set; }
    }
}
