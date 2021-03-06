﻿using PP_Parser.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Entities.Statuses
{
    public class MultiStatus : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID BaseDef { get; set; }
        public PhoenixObjectID Source { get; set; }
        public bool Applied { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> Statuses { get; set; }
    }
}
