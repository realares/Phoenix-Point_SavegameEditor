using Base;

namespace PhoenixPoint.Common.Levels.Missions
{
    public class TacMissionData : PhonixBaseObjectBaseValue
    {
        public MissionId MissionId { get; set; }
        public PhoenixObjectID MissionType { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> MissionParticipants { get; set; }
        public bool CrateStructuralTargets { get; set; }
        public float StructuralTargetsIntegrity { get; set; }
        public bool UsePhoenixBaseLayout { get; set; }
        public PhoenixObjectID PhoenixBaseLayout { get; set; }
    }

}
