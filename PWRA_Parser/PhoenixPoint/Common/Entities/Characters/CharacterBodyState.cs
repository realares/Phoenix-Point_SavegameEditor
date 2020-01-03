using PP_Parser.Parser;

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
