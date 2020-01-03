using PP_Parser.Parser;

namespace PhoenixPoint.Tactical.Levels.Destruction
{
    public class Breakable : PhonixBaseObjectBaseValue
    {
        public Base.Levels.SceneObjectIds.SceneObjectId GuidInScene { get; set; }
        public bool _broken { get; set; }
    }
}
