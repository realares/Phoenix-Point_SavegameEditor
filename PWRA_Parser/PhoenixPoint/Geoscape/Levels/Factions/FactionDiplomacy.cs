using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Levels.Factions
{
    public class FactionDiplomacy : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericCollection<PhoenixObjectID> _factionsDiplomacyState { get; set; }
        public PhoenixObjectID Def { get; set; }
        public PhoenixObjectID Party { get; set; }

        public PhoenixGenericCollection<PhoenixGenericKeyValue<PhoenixObjectID, PhoenixObjectID>> _relations { get; set; }
    }


}
