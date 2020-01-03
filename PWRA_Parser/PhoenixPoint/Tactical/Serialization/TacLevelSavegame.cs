using PP_Parser.Parser;

namespace PhoenixPoint.Tactical.Serialization
{
    public class TacLevelSavegame
    {
        public class Data : PhonixBaseObjectBaseValue
        {
            public PhoenixPoint.Tactical.Levels.TacLevelInstanceData LevelInstanceData { get; set; }
            public PhoenixGenericCollection<PhoenixObjectID> Destructables { get; set; }
            public PhoenixGenericCollection<PhoenixObjectID> Actors { get; set; }
            public PhoenixObjectID VoxelMatrix { get; set; }
            public PhoenixObjectID DarkVolumesManager { get; set; }

            
        }
    }
}
