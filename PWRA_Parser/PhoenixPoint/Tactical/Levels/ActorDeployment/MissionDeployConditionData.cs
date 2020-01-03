using PP_Parser.Parser;

namespace PhoenixPoint.Tactical.Levels.ActorDeployment
{
    public class MissionDeployConditionData : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID ActorTagDef { get; set; }
        public bool ExcludeActor { get; set; }
        public int ActivateOnTurn { get; set; }
        public int DeactivateAfterTurn { get; set; }
    }
}
