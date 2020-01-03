using Base;
using Base.UI;
using Base.Utils;
using PhoenixPoint.Common.Entities;
using PhoenixPoint.Common.Entities.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Tactical.Entities
{
    public class TacActorInstanceData : PhonixBaseObjectBaseValue2
    {

        public float Health { get; set; }
        public float WillPoints { get; set; }
        public PhoenixObjectID AIActorData { get; set; }
        public PhoenixGenericCollection<string> AbilityTraits { get; set; }
        public PhoenixGenericCollection<CharacterBodyState.BodyItemData> DestroyedSubaddons { get; set; }
        public PhoenixGenericCollection<PhoenixPoint.Tactical.Entities.ItemData> EquipmentItems { get; set; }
        public PhoenixGenericCollection<PhoenixPoint.Tactical.Entities.ItemData> MountedEquipmentItems { get; set; }
        public PhoenixGenericCollection<PhoenixPoint.Tactical.Entities.ItemData> BodypartItems { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> AdditionalAbilities { get; set; }
        public PhoenixObjectID LevelProgression { get; set; }
        public int BaseStrength { get; set; }
        public int BaseWill { get; set; }
        public int BaseSpeed { get; set; }
        public PhoenixObjectID OverrideViewElement { get; set; }
        public LocalizedTextBind OverrideName { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> AdditionalGameTags { get; set; }
        public PhoenixObjectID FactionDef { get; set; }
        public PhoenixEnum MissionParticipant { get; set; }
        public GeoTacUnitId GeoUnitId { get; set; }
        public PhoenixGenericCollection<KnownPhoenixObjectID<Base.Entities.Statuses.StatusStat>> Stats { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> Statuses { get; set; }
        public PhoenixGenericCollection<PhoenixPoint.Tactical.Entities.ItemData> InventoryItems { get; set; }
        public PoseTransform ModelPose { get; set; }
        public int Contribution { get; set; }
        public PhoenixObjectID CurrentMissionHistory { get; set; }
        public bool OverrideTransform { get; set; }
        public UnityEngine.CoreModule.Vector3 Pos { get; set; }
        public UnityEngine.CoreModule.Quaternion Rot { get; set; }
        public PhoenixObjectID Source { get; set; }
        public PhoenixObjectID TimingData { get; set; }
    }
}
