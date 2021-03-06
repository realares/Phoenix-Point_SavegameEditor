﻿using Base.Core;
using Base.Utils;
using PP_Parser.Parser;


namespace PhoenixPoint.Geoscape.Levels.Factions
{
    public class GeoPhoenixFaction
    {
        public class ExtendedInstanceData : PhonixBaseObjectBaseValue
        {
            public int Skillpoints { get; set; }

            public Base.Core.NextUpdate NextBaseUpdate { get; set; }

            public PhoenixGenericCollection<PhoenixObjectID> CapturedUnits { get; set; }
            public PhoenixObjectID DismambleUnit { get; set; }
            public TimeUnit DismambleAt { get; set; }
            public PhoenixEnum DismambleForResource { get; set; }
            public PhoenixObjectID Replenisher { get; set; }
            public PhoenixGenericCollection<PhoenixObjectID> Bases { get; set; }
            public PhoenixObjectID StartingBase { get; set; }
        }
    }
}
