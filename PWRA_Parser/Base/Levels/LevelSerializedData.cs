﻿using Base.Serialization.General;
using PP_Parser.Base;
using PP_Parser.Parser;
using System.Collections.Generic;

namespace Base.Levels
{
    public class LevelSerializedData : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericCollection<PhoenixObjectID> Objects { get; set; }

        public override string ToString()
        {
            return "LevelSerializedData";
        }
    }
}
