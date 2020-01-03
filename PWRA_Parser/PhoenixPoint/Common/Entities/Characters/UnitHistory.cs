using Base;

namespace PhoenixPoint.Common.Entities.Characters
{
    public class UnitHistory : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericCollection<PhoenixObjectID> _items { get; set; }
    }
}
