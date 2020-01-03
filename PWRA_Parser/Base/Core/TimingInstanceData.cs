using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Core
{
    public class TimingInstanceData : PhonixBaseObjectBaseValue
    {
        public bool Paused { get; set; }
        public float Scale { get; set; }
        public TimeUnit StartTime { get; set; }
        public TimeUnit StartFixedTime { get; set; }
        public TimeUnit OwnNow { get; set; }
        public TimeUnit OwnFixedNow { get; set; }
    }
}
