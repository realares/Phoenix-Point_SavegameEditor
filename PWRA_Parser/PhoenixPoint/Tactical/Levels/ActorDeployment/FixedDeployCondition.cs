using PP_Parser.Parser;

namespace PhoenixPoint.Tactical.Levels.ActorDeployment
{
    public class FixedDeployCondition : PhonixBaseObjectBaseValue
    {
        public FixedDeployConditionData FixedData { get; set; }
        public int _turnsPassed { get; set; }
        public bool _deployed { get; set; }
        public PhoenixObjectID DeployZone { get; set; }
    }

}
