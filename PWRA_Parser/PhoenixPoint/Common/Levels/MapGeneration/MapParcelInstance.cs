using Base.Levels.SceneObjectIds;
using PP_Parser.Parser;

namespace PhoenixPoint.Common.Levels.MapGeneration
{
    public class MapParcelInstance : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID MapParcelDef { get; set; }
        public float RotationDegrees { get; set; }
        public SceneObjectId MapParcelPositionId { get; set; }
        
    }
}
