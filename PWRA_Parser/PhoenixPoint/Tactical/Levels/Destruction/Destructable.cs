using Base.Utils;
using PP_Parser.Parser;

namespace PhoenixPoint.Tactical.Levels.Destruction
{

    public class Destructable : PhonixBaseObjectBaseValue
    {
        public Base.Levels.SceneObjectIds.SceneObjectId GuidInScene { get; set; }
        public PhoenixGenericArray<PhoenixEnum> _gridStorage { get; set; }
       
    }
}
