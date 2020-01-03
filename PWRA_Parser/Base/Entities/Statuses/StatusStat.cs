using Base.Utils;
using PP_Parser.Parser;

namespace Base.Entities.Statuses
{
    public class StatusStat : PhonixBaseObjectBaseValue
    {
        public ModifiableValue Min { get; set; }
        public ModifiableValue Max { get; set; }
        public string Name { get; set; }
        public ModifiableValue Value { get; set; }
        public PhoenixGenericCollection<StatModification> Modifications { get; set; }
        public PhoenixEnum _roundingMode { get; set; }
    }
}
