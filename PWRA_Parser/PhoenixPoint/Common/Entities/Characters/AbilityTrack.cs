using Base.Utils;
using PP_Parser.Parser;

namespace PhoenixPoint.Common.Entities.Characters
{
    public class AbilityTrack : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericArray<PhoenixObjectID> AbilitiesByLevel { get; set; }
        public PhoenixEnum Source { get; set; }
    }
}
