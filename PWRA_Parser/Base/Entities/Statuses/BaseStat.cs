using Base.Utils;

namespace Base.Entities.Statuses
{
    public class BaseStat : PhonixBaseObjectBaseValue
    {
        public string Name { get; set; }
        public ModifiableValue Value { get; set; }
        public PhoenixGenericCollection<StatModification> Modifications { get; set; }
        public PhoenixEnum _roundingMode { get; set; }
    }
}
