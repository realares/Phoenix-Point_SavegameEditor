using Base;
using Base.Core;
using Base.Entities;
using Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Geoscape.Entities
{
    public class GeoScanner : PhonixBaseObjectBaseValue
    {
        public ActorCreateData ActorCreateData { get; set; } // 28
        public GeoScanner.GeoScannerInstanceData SerializationData { get; set; } // 47


        public class GeoScannerInstanceData : PhonixBaseObjectBaseValue
        {
            public TimeUnit ExpansionEndDate { get; set; }
            public PhoenixObjectID Owner { get; set; }
            public PhoenixObjectID Location { get; set; }
            public int SitesRevealed { get; set; }
            public bool OverrideTransform { get; set; }
            public UnityEngine.CoreModule.Vector3 Pos { get; set; }
            public UnityEngine.CoreModule.Quaternion Rot { get; set; }
            public PhoenixObjectID Source { get; set; }
            public PhoenixObjectID TimingData { get; set; }
        }
        public class ScannerHistoryData : PhonixBaseObjectBaseValue
        {
            public TimeUnit Time { get; set; }

            public PhoenixObjectID Site { get; set; }
            public float Range { get; set; }
            public bool IsMaxRange { get; set; }
        }
    }
}
