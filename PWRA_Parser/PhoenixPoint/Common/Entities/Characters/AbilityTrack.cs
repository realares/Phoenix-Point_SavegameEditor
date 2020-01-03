using Base;
using Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Common.Entities.Characters
{
    public class AbilityTrack : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericArray<PhoenixObjectID> AbilitiesByLevel { get; set; }
        public PhoenixEnum Source { get; set; }
    }
}
