using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Common.Entities.Characters
{
    public class CharacterBodyState
    {
        public class BodyItemData : PhonixBaseObjectBaseValue
        {
            public PhoenixObjectID itemDef { get; set; }
            public string slotName { get; set; }
        }
    }
}
