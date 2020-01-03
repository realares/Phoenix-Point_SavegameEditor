using Base;
using Base.Utils;

namespace PhoenixPoint.Tactical.Levels.Mist
{
    public class TacticalVoxel : PhonixBaseObjectBaseValue
    {
        public UnityEngine.CoreModule.Vector3 Position { get; set; }

        public PhoenixObjectID VoxelManager { get; set; }

        public PhoenixEnum _voxelType { get; set; }
    }
}
