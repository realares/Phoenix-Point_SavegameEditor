using Base;
using Newtonsoft.Json;
using PhoenixPoint.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Geoscape.Entities
{
    public class GeoAlienMutationClass : PhonixBaseObjectBaseValue
    {

        [JsonProperty("Id")]
        public GeoTacUnitId Id { get; set; }


        public int DeploymentCost { get; set; }

        [JsonProperty("_bodyParts")]
        public PhoenixGenericCollection<PhoenixObjectID> _bodyParts { get; set; }

        [JsonProperty("Equipment")]
        public PhoenixGenericCollection<PhoenixObjectID> Equipment { get; set; }

        [JsonProperty("TemporaryUnit")]
        public bool TemporaryUnit { get; set; }

        [JsonProperty("_id")]
        public GeoTacUnitId _Id { get; set; }

        [JsonProperty("_classDef")]
        public PhoenixObjectID _classDef { get; set; }

        [JsonProperty("_factionDef")]
        public PhoenixObjectID _factionDef { get; set; }

    }
}
