using PP_Parser.Parser;


namespace PhoenixPoint.Geoscape.Levels.Factions
{
    public class GeoAlienFaction
    {
        public class ExtendedInstanceData : PhonixBaseObjectBaseValue
        {
            public Base.Core.NextUpdate NextBaseBuildUpdate { get; set; }
            public Base.Core.NextUpdate NextHavenAttackUpdate { get; set; }

            public Base.Core.NextUpdate NextMistGeneratorActivationUpdate { get; set; }

            public int EvolutionProgress { get; set; }
            public PhoenixGenericCollection<PhoenixObjectID> EvolvedBodyparts { get; set; }
            public PhoenixGenericCollection<PhoenixObjectID> BodyPartEvolutionHistory { get; set; }
            public PhoenixGenericCollection<int> BodyPartEvolutionPoints { get; set; }

            public int SDI { get; set; }
            public bool MistEnabled { get; set; }
            public bool AlienActivityEnabled { get; set; }
        }
    }
}
