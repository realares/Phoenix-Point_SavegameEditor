using Base.Core;
using PP_Parser.Parser;

namespace Base.Levels
{
    public class LevelSceneBinding : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID LevelDef { get; set; }

        public PhoenixGenericCollection<SceneReference> LevelScenes { get; set; }

        public bool ForceLoad { get; set; }

        public PhoenixObjectID LevelParams { get; set; }
    }
}
