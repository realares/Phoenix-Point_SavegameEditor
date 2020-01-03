using Base;
using PP_Parser.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
