using PP_Parser.Parser;

namespace PhoenixPoint.Common.Levels.ActorDeployment
{
    public class ActorDeployLimit : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID ActorTag { get; set; }
        public Base.Utils.RangeDataInt ActorLimit { get; set; }
        public int SpawnedCount { get; set; }

    }
}
