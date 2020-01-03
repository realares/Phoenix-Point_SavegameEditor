using PP_Parser.Parser;

namespace Base.Serialization
{
    public class TacticalSaveDependency : PhonixBaseObjectBaseValue
    {
        public string CorrespondingGeoscapeSave { get; set; }
        public string CorrespondingRestartSave { get; set; }
    }
}
