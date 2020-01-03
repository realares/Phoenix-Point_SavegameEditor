using Base.Utils;
using PP_Parser.Parser;
using UnityEngine.CoreModule;

namespace PhoenixPoint.Tactical.Entities.StructuralTargets
{
    public class StructuralTargetInstanceData : PhonixBaseObjectBaseValue2
    {
        public float Health { get; set; }
        public float WillPoints { get; set; }
        public int FacilityID { get; set; }
        public float Armor { get; set; }
        public Vector3 UIElementWorldOffset { get; set; }
        public Vector3 UIElementScreenOffset { get; set; }
        public PhoenixObjectID OverrideViewElement { get; set; }
        public PhoenixObjectID OverrideName { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> AdditionalGameTags { get; set; }
        public PhoenixObjectID FactionDef { get; set; }
        public PhoenixEnum MissionParticipant { get; set; }
        public PhoenixPoint.Common.Entities.GeoTacUnitId GeoUnitId { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> Stats { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> Statuses { get; set; }
        public PhoenixObjectID InventoryItems { get; set; }
        public PhoenixObjectID ModelPose { get; set; }
        public int Contribution { get; set; }
        public PhoenixObjectID CurrentMissionHistory { get; set; }
        public bool OverrideTransform { get; set; }
        public UnityEngine.CoreModule.Vector3 Pos { get; set; }
        public UnityEngine.CoreModule.Quaternion Rot { get; set; }
        public PhoenixObjectID Source { get; set; }
        public PhoenixObjectID TimingData { get; set; }


    }
}
