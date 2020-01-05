using PhoenixPoint.Geoscape.Entities.DifficultySystem;
using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape
{
    public class GeoLevelInstanceData : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID TimingData { get; set; }
        public int NextTacUnitId { get; set; }

        public PhoenixGenericCollection<PhoenixObjectID> FactionsInstanceData { get; set; }

        public PhoenixGenericCollection<PhoenixObjectID> TacUnits { get; set; }

        public object MissionToComplete { get; set; }
        public PhoenixObjectID EventSystemInstanceData { get; set; }

        public DynamicDifficultySystem.DifficultyInstanceData DynamicDifficultySystemInstanceData { get; set; }

        public PhoenixObjectID CurrentDifficultyLevel { get; set; }
        public PhoenixObjectID MistData { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> ScannerHistoryData { get; set; }
        public PhoenixObjectID TutorialInstanceData { get; set; }
        public PhoenixObjectID GeoscapeLog { get; set; }
        public PhoenixObjectID PhoenixpediaData { get; set; }
        public PhoenixObjectID LastSelectedActor { get; set; }
    }
}
