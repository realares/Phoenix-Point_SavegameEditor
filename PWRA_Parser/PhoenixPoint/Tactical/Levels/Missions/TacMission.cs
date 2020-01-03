using PP_Parser.Parser;

namespace PhoenixPoint.Tactical.Levels.Missions
{
    public class TacMission : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID BaseDef { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> ParticipantSpawns { get; set; }
        public Base.Levels.SceneObjectIds.SceneObjectId DeploymentSetId { get; set; }
    }
    
}
