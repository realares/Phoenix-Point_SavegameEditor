using Base.Entities.Statuses;
using PP_Parser.Parser;

namespace PhoenixPoint.Common.Entities.Characters
{
    public class CharacterFatigue : PhonixBaseObjectBaseValue
    {
        public KnownPhoenixObjectID<StatusStat> _stamina { get; set; }
        public PhoenixTagDef _sheetDef { get; set; }
        public int _hunger { get; set; }
    }
}
