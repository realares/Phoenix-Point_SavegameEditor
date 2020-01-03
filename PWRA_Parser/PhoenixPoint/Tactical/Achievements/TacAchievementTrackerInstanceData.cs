using PP_Parser.Parser;

namespace PhoenixPoint.Tactical.Achievements
{
    public class TacAchievementTrackerInstanceData : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericCollection<PhoenixObjectID> KillStats { get; set; }
        public int Turn { get; set; }
    }
}
