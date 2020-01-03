using PP_Parser.Parser;
using System;

namespace PhoenixPoint.Geoscape.Entities.DifficultySystem
{
    public class DynamicDifficultySystem : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericArray<Double> BattleOutcomes { get; set; }

        public PhoenixGenericArray<double> CurrentDeploymentPerThreatLevel { get; set; }
        public PhoenixGenericArray<double> MinDeploymentPerThreatLevel { get; set; }
    }
}
