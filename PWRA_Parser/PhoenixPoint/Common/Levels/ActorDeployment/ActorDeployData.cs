using Base;
using PhoenixPoint.Tactical.Entities;
using PP_Parser.BinParser;
using PP_Parser.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Common.Levels.ActorDeployment
{
    public class ActorDeployData : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID ComponentSetDef { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> ActorTags { get; set; }
        public PhoenixTagDef InstanceDef { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double ChanceWeight { get; set; }
        public bool CanBeInitialDeployment { get; set; }
        public bool CanBeReinforcement { get; set; }
        public bool CanFailToSpawn { get; set; }
        public float DeployCost { get; set; }
        public bool Unique { get; set; }
        public bool DeployWithPriority { get; set; }
        public PhoenixObjectID ActorInstance { get; set; }

        [DynamicReflect]
        public PhonixBaseObjectBaseValue2 ______InstanceData
        {
            get;
            set;
        }
    }
}
