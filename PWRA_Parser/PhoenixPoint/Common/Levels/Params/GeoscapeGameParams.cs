using Base.Platforms;
using PP_Parser.Parser;

namespace PhoenixPoint.Common.Levels.Params
{
    public class GeoscapeGameParams : PhonixBaseObjectBaseValue
    {
        public TacticalGameResult LastTacticalGameResult { get; set; }
        public PhoenixObjectID Difficulty { get; set; }
        public bool TutorialEnabled { get; set; }
        public bool IsIronmanMode { get; set; }
        public bool PlayIntroCinematic { get; set; }
        //public EntitlementDef EnabledDlc { get; set; }
        public PhoenixGenericArray<EntitlementDef> EnabledDlc { get; set; }

    }

    public class TacticalGameResult
    {

    }
}


