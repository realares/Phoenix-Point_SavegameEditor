using PP_Parser.Parser;

namespace PhoenixPoint.Tactical.Levels.ActorDeployment
{
    public class MissionDeployCondition : PhonixBaseObjectBaseValue
    {
        public MissionDeployConditionData MissionData { get; set; }
        public PhoenixObjectID DeployZone { get; set; }
    }

}
