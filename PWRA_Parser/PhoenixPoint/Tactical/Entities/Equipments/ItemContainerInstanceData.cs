using Base;
using Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Tactical.Entities.Equipments
{
    public class ItemContainerInstanceData : PhonixBaseObjectBaseValue
    {
        public float Health { get; set; }
        public float WillPoints { get; set; }
        public PhoenixObjectID OverrideViewElement { get; set; }
        public PhoenixObjectID OverrideName { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> AdditionalGameTags { get; set; }
        public PhoenixObjectID FactionDef { get; set; }
        public PhoenixEnum MissionParticipant { get; set; }
        public Common.Entities.GeoTacUnitId GeoUnitId { get; set; }
        public PhoenixObjectID Stats { get; set; }
        public PhoenixObjectID Statuses { get; set; }
        public PhoenixGenericCollection<PhoenixPoint.Tactical.Entities.ItemData> InventoryItems { get; set; }
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
