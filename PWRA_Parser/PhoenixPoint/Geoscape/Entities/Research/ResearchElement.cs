using Base;
using Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Geoscape.Entities.Research
{
    public class ResearchElement : PhonixBaseObjectBaseValue
    {
        public bool IsInProgress { get; set; }
        public PhoenixEnum _state { get; set; }
        public string ResearchID { get; set; }
        public float ResearchProgress { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> _serializableRevealRequirementsData { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> _serializableUnlockRequirementsData { get; set; }
    }
}
