using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Common.Core
{
    public class PartyDiplomacy : PhonixBaseObjectBaseValue
    {

        public PhoenixObjectID Def { get; set; }
        public PhoenixObjectID Party { get; set; }
        public PhoenixGenericCollection<PhoenixGenericKeyValue<PhoenixObjectID, PhoenixObjectID>> _relations { get; set; }

        public class Relation : PhonixBaseObjectBaseValue
        {
            public PhoenixObjectID WithParty { get; set; }
            public PhoenixObjectID _withParty { get; set; }
            public int _diplomacy { get; set; }
            public int MaxValue { get; set; }
            public int MinValue { get; set; }
        }
    }
}
