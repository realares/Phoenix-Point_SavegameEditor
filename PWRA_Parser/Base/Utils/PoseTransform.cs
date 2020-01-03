using PP_Parser.Parser;

namespace Base.Utils
{
    public class PoseTransform : PhonixBaseObjectBaseValue
    {
        public string Name { get; set; }
        public UnityEngine.CoreModule.Vector3 Position { get; set; }
        public UnityEngine.CoreModule.Quaternion Rotation { get; set; }
        public PhoenixGenericCollection<Base.Utils.PoseTransform> Children { get; set; }
    }
}