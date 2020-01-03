using Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Geoscape.Entities
{
    public class ItemStorage : PhonixBaseObjectBaseValue
    {
        [JsonProperty("_storageItems")]
        public PhoenixGenericCollection<PhoenixGenericKeyValue<PhoenixObjectID, PhoenixObjectID>> _storageItems { get; set; }

        [JsonProperty("_isFactionStorage")]
        public bool _isFactionStorage { get; set; }
    }
}
