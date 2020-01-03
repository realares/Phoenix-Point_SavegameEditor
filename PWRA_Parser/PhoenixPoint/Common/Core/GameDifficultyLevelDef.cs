using PP_Parser.Parser;

namespace PhoenixPoint.Common.Core
{
    public class GameDifficultyLevelDef : PhoenixTagDef
    {
    }

    public class GameDifficultyLevelDef_Refference : PhoenixObjectID
    {
        public GameDifficultyLevelDef GetRef(SaveGame saveGame)
        {
            var r = saveGame.Metadata.Objects.Find(x => x.ObjectID == this.ObjectID);
             if (r == null) return null;
            return r.ObjectValue as GameDifficultyLevelDef;
        }
    }
}
