using Base;
using Base.Utils;
using PhoenixPoint.Common.Levels.MapGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Common.Levels.Params
{
    public class TacticalGameParams : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID MissionDef { get; set; }

        public PhoenixObjectID MapPlotGenerationData { get; set; }

        public UnityDateTime GlobalTime { get; set; }

        public string LocationName { get; set; }
        public bool EnumPlotsMode { get; set; }
        public MapPlotInstanceData MapPlotInstanceData { get; set; }
        public PhoenixObjectID __MapPlotDebugInstanceData { get; set; }
        public PhoenixObjectID EnterMissionCutscene { get; set; }
        public PhoenixObjectID ExitMissionWinCutscene { get; set; }
        public PhoenixObjectID ExitMissionLoseCutscene { get; set; }
        public PhoenixTagDef BaseLayoutDef { get; set; }
        public PhoenixObjectID BaseTemplate { get; set; }
        public bool GenerateFakes { get; set; }
    }
}
