using PP_Parser.Parser;

namespace PhoenixPoint.Common.Entities.Characters
{
    public class AbilityTrackSlot : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID Ability { get; set; }
        public bool RequiresPrevAbility { get; set; }
    }
}
