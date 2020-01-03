using Base.Serialization.General;
using JsonSubTypes;
using Newtonsoft.Json;
using PhoenixPoint.Tactical.Entities;
using PP_Parser.Base;
using PP_Parser.BinParser;
using PP_Parser.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{

    public class SaveGame
    {
        [JsonIgnore]
        public static SaveGame Instance { get; set; }


        public int Version { get; set; }
        public PhoenixObjectHolder Metadata { get; set; }
        public PhoenixObjectHolder Contents { get; set; }
        public PhoenixObjectHolder RuntimeDefs { get; set; }

    }


    public class PhoenixBaseObjects
    {
        public int ObjectID { get; set; }
        public bool TopLevel { get; set; }

        [DynamicReflect]
        public PhonixBaseObjectBaseValue ObjectValue { get; set; }
    }

    

    [JsonConverter(typeof(SubtypesForJson), "#Type", true)]
    public class PhonixBaseObjectBaseValue
    {
        [JsonProperty("#Type", Order = -200)]
        public int _Type { get; set; }
    }

    [JsonConverter(typeof(SubtypesForJson), "#Type", true)]
    public abstract class PhonixBaseObjectBaseValue2
    {
        [JsonProperty("#Type", Order = -200)]
        public int _Type { get; set; }
    }

    public class PhoenixObjectHolder
    {
        //[JsonProperty(Order = 1)]
        public List<PhoenixBaseObjects> Objects { get; set; }

        public List<int> CreateOrder { get; set; }

        public List<TypeData> Types { get; set; }
    }
    public class PhonixBaseObjectValue : PhonixBaseObjectBaseValue { }
    
    public class PhoenixGenericCollection<T> : PhonixBaseObjectValue
    {
        public List<T> CollectionValues { get; set; }
    }

    public class PhoenixGenericArray<T> : PhonixBaseObjectValue
    {
        public PhoenixGenericCollection<int> ArrayDimensions { get; set; }

        private List<T> _CollectionValues;
        public List<T> CollectionValues
        {
            get => _CollectionValues;
            set
            {
                _CollectionValues = value;
                if (ArrayDimensions == null)
                    ArrayDimensions = new PhoenixGenericCollection<int>()
                    {
                        _Type = SubTyper.Instance.GetKey(typeof(PhoenixGenericCollection<int>)),
                        CollectionValues = new List<int>() { value.Count }
                    };
            }
        }

        //private T[] _CollectionValues;
        //public T[] CollectionValues
        //{
        //    get => _CollectionValues;
        //    set
        //    {
        //        _CollectionValues = value;
        //        if (ArrayDimensions == null)
        //            ArrayDimensions = new PhoenixGenericCollection<int>()
        //            {
        //                _Type = SubTyper.Instance.GetKey(typeof(PhoenixGenericCollection<int>)),
        //                CollectionValues = new List<int>() { value. }
        //            };
        //    }
        //}
    }
    public class PhoenixObjectID
    {
        [JsonProperty(Order = -200)]
        public int ObjectID { get; set; }
    }
    public class PhoenixGenericKeyValue<K, V> : PhonixBaseObjectBaseValue
    {
        public K Key { get; set; }
        public V Value { get; set; }
    }

    public class PhoenixTagDef : PhonixBaseObjectBaseValue
    {
        public string SerializationGuid { get; set; } 
    }
    public class KnownPhoenixObjectID<T> : PhoenixObjectID where T : PhonixBaseObjectBaseValue
    {
        [JsonIgnore()]
        public T Instance
        {
            get
            {
                return SaveGame.Instance.Contents.Objects.Find(x => x.ObjectID == this.ObjectID)?.ObjectValue as T;
            }
        }
        public object Raw()
        {
            return SaveGame.Instance.Contents.Objects.Find(x => x.ObjectID == this.ObjectID)?.ObjectValue;
        }
        public G As<G>() where G : PhonixBaseObjectBaseValue
        { 
            return SaveGame.Instance.Contents.Objects.Find(x => x.ObjectID == this.ObjectID)?.ObjectValue as G;
        }
    }
}

namespace Base.Serialization.General
{
    public class TypeData : PhonixBaseObjectBaseValue
    {
        public string TypeName { get; set; }
        public int Id { get; set; } = -1;
        public int Version { get; set; }
    }
}