using PP_Parser.Parser;

namespace PhoenixPoint.Common.Core
{
    public class PartyDiplomacy : PhonixBaseObjectBaseValue
    {

        public PhoenixObjectID Def { get; set; }
        public PhoenixObjectID Party { get; set; }
        public PhoenixGenericCollection<PhoenixGenericKeyValue<PhoenixObjectID, PhoenixObjectID>> _relations { get; set; }

        public class Relation : PhonixBaseObjectBaseValue
        {
            public PhoenixObjectID WithParty { get; set; }
            public PhoenixObjectID _withParty { get; set; }
            public int _diplomacy { get; set; }
            public int MaxValue { get; set; }
            public int MinValue { get; set; }
        }
    }
}
