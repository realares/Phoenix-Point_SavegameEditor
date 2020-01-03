using PP_Parser.Parser;
using PP_Parser.Parser.Binary;

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
