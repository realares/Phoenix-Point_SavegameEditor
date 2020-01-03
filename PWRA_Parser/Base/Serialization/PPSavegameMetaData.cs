using PhoenixPoint.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PP_Parser.Base;
using Base.Utils;
using Base.Platforms;

namespace Base.Serialization
{
    public class PPSavegameMetaData : PhonixBaseObjectBaseValue
    {

        public PPGameId GameId { get; set; }

        public UnityDateTime IngameTime { get; set; }

        public string LocationName { get; set; }

        public string UserSetName { get; set; }
        public string ScreenshotStringData { get; set; }

        public PhoenixEnum SaveType { get; set; }

        public GameDifficultyLevelDef_Refference DifficultyDef { get; set; }

        public TacticalSaveDependency TacticalSaveDependency { get; set; }

        //public EntitlementDef EnabledDlc { get; set; }
        public PhoenixGenericArray<EntitlementDef> EnabledDlc { get; set; }

        public string Name { get; set; }

        public UnityDateTime SaveCreated { get; set; }

        public int Version { get; set; }
        public int BuildRevisionNumber { get; set; }
        public PhoenixObjectID LevelSceneBinding { get; set; }

        
    }
}



