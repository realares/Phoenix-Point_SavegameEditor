using PP_Parser.Parser;

namespace PhoenixPoint.Tactical.Levels.TacticalLevelLights
{
    public class DarkVolumesManager : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericCollection<PhoenixGenericKeyValue<string, PhoenixGenericCollection<UnityEngine.CoreModule.Vector3>>> _revealedPositions { get; set; }
    }
}
