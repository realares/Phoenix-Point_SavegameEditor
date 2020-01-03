using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Geoscape.Entities.Research
{
    public class Research : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericArray<PhoenixObjectID> AllResearchesArray { get; set; }
        public PhoenixObjectID CurrentResearch { get; set; }
        public PhoenixObjectID _factionDef { get; set; }
        public bool Paused { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> _researchQueue { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> _oldResearchQueue { get; set; }
    }
}
