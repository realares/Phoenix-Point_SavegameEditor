using Base.Utils;
using PP_Parser.Parser;
using PP_Parser.Parser.Binary;

namespace PhoenixPoint.Geoscape.Entities
{
    public class GeoHavenDefenseMissionInstanceData : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID MissionSite { get; set; }
        public PhoenixEnum Status { get; set; }
        public PhoenixEnum ObjectiveType { get; set; }
        public int AttackerDeployment { get; set; }
        public int DefenderDeployment { get; set; }

        public PhoenixGenericCollection<PhoenixObjectID> AttackingSites { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double TacticalRewardThreatMod { get; set; }
        public int DeploymentReinforcementPart { get; set; }
        public int DeploymentTurns { get; set; }
        public int WaitTimeLeft { get; set; }
        public PhoenixTagDef AttackedZoneDef { get; set; }
        public int MissionSeed { get; set; }

}
}
