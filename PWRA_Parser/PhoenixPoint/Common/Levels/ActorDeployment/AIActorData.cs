using PP_Parser.Parser;
using PP_Parser.Parser.Binary;

namespace PhoenixPoint.Common.Levels.ActorDeployment
{
    public class AIActorData : PhonixBaseObjectBaseValue
    {
        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double InitialAlertRadius { get; set; }

        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double AlertRadiusBonus { get; set; }
        public bool IsAlerted { get; set; }
        public bool JustAlerted { get; set; }


    }
}
