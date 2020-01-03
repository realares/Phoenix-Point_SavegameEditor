using Base;
using Base.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Geoscape.Levels.Factions
{
    public class FactionAggressionRequest : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID AgainstFaction { get; set; }
        public PhoenixObjectID FromFaction { get; set; }

        public PhoenixTagDef AgainstZoneType { get; set; }
        public bool Accepted { get; set; }
        public LocalizedTextBind Description { get; set; }
        public LocalizedTextBind Summary { get; set; }
        public PhoenixObjectID ResourcesReward { get; set; }
        public int FactionDiplomacyReward { get; set; }
    }
}
