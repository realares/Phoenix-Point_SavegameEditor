using PP_Parser.Parser;

namespace PhoenixPoint.Tactical.Entities.ActorsInstance
{
    public class TacActorData : PhonixBaseObjectBaseValue
    {
        public string Name { get; set; }
        public bool LocalizeName { get; set; }
        public PhoenixObjectID PrefabSource { get; set; }
        public PhoenixObjectID ComponentSetTemplate { get; set; }
        public PhoenixGenericArray<PhoenixObjectID> OverrideComponentDefs { get; set; }
        public PhoenixObjectID ViewElementDef { get; set; }
        public PhoenixGenericArray<PhoenixObjectID> GameTags { get; set; }
    }
}
