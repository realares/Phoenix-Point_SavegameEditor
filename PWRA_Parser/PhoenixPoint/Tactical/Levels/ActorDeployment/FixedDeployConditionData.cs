using PP_Parser.Parser;
using PP_Parser.Parser.Binary;

namespace PhoenixPoint.Tactical.Levels.ActorDeployment
{
    public class FixedDeployConditionData : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID TacActorDef { get; set; }
        public int TurnNumber { get; set; }
        public bool CanFailToSpawn { get; set; }
        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double SpawnChancePerc { get; set; }
    }

}
