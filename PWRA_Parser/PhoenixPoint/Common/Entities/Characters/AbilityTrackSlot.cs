using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Common.Entities.Characters
{
    public class AbilityTrackSlot : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID Ability { get; set; }
        public bool RequiresPrevAbility { get; set; }
    }
}
