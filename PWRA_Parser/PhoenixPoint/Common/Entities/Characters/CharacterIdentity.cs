using Base;
using Base.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Common.Entities.Characters
{
    public class CharacterIdentity : PhonixBaseObjectBaseValue
    {
        public string Name { get; set; }
        public PhoenixEnum Sex { get; set; }

        [JsonProperty("VoiceProfileTag")]
        public PhoenixObjectID VoiceProfileTag { get; set; }

        [JsonProperty("CountryTag")]
        public PhoenixObjectID CountryTag { get; set; }

        [JsonProperty("FaceTag")]
        public PhoenixObjectID FaceTag { get; set; }

        [JsonProperty("RaceTag")]
        public PhoenixObjectID RaceTag { get; set; }

        [JsonProperty("HairTag")]
        public PhoenixObjectID HairTag { get; set; }

        [JsonProperty("FacialHairTag")]
        public PhoenixObjectID FacialHairTag { get; set; }

        [JsonProperty("HairColorTag")]
        public PhoenixObjectID HairColorTag { get; set; }
        
        [JsonProperty("EyeColorTag")] 
        public PhoenixObjectID EyeColorTag { get; set; }
        
        [JsonProperty("PrimaryColorTag")] 
        public PhoenixObjectID PrimaryColorTag { get; set; }
        
        [JsonProperty("SecondaryColorTag")] 
        public PhoenixObjectID SecondaryColorTag { get; set; }
        
        [JsonProperty("PatternTag")] 
        public PhoenixObjectID PatternTag { get; set; }
    }
}
