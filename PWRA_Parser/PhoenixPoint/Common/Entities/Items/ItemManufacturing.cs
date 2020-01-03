using PP_Parser.Parser;

namespace PP_Parser.PhoenixPoint.Common.Entities.Items
{
    public class ItemManufacturing : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID CurrentItem { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> _queue { get; set; }
        public float _accumulatedManufacturePoints { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> _oldManufactureQueue { get; set; }

        public class ManufactureQueueItem : PhonixBaseObjectBaseValue
        {
            public PhoenixObjectID Item { get; set; }
            public int AccumulatedPoints { get; set; }
        }
    }
}
