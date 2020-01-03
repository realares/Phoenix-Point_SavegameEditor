using PP_Parser.Parser;

namespace PhoenixPoint.Tactical.Levels.Mist
{
    public class TacticalVoxelMatrix : PhonixBaseObjectBaseValue
    {
        public bool HadMist { get; set; }

        public bool HadGoo { get; set; }

        public PhoenixGenericArray<PhoenixObjectID> _voxels { get; set; }
    }
}
