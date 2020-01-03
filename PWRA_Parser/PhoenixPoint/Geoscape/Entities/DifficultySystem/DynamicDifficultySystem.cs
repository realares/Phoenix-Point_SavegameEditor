﻿using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Geoscape.Entities.DifficultySystem
{
    public class DynamicDifficultySystem : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericArray<Double> BattleOutcomes { get; set; }

        public PhoenixGenericArray<double> CurrentDeploymentPerThreatLevel { get; set; }
        public PhoenixGenericArray<double> MinDeploymentPerThreatLevel { get; set; }
    }
}
