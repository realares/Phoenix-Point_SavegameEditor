using Base;
using PP_Parser.Parser;

namespace PhoenixPoint.Tactical.Levels.Missions
{
    public class TacParticipantSpawn : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID MissionFactionData { get; set; }

        public float DeploymentPointsUsed { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> _actorDeployData { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> _actorDeployLimit { get; set; }
        public PhoenixObjectID _nextDeployment { get; set; }
        public PhoenixObjectID TacMission { get; set; }
    }
    
}
