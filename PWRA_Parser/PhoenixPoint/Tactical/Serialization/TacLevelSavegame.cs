using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
