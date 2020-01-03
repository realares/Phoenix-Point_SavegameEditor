using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Geoscape.Entities.Research.Requirement
{
    public class ResearchRequirement
    {
        public class InstanceData : PhonixBaseObjectBaseValue
        {
            public string ResearchRequirementDefName { get; set; }
            public int Progress { get; set; }
        }
    }
}
