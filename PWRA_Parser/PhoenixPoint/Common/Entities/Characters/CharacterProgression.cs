using Base;
using PhoenixPoint.Tactical.Entities.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Common.Entities.Characters
{

    public class CharacterProgression : PhonixBaseObjectBaseValue
    {
        public KnownPhoenixObjectID<SpecializationDef> MainSpecDef { get; set; }
        public int SkillPoints { get; set; }
        public PhoenixObjectID _secondarySpecializationDef { get; set; }
        public PhoenixGenericCollection<KnownPhoenixObjectID<AbilityTrack>> _abilityTracks { get; set; }
        public PhoenixGenericCollection<KnownPhoenixObjectID<TacticalAbilityDef>> _abilities { get; set; }
        public KnownPhoenixObjectID<LevelProgression> LevelProgression { get; set; }
        public PhoenixTagDef BaseStatSheet { get; set; }
        public PhoenixGenericCollection<int> _baseStats { get; set; }
    }
}
