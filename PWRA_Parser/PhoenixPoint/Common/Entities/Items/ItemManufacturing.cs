using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
