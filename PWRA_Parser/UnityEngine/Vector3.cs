using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PP_Parser.Parser;
using PP_Parser.Parser.Binary;
using System;
using System.Linq;

namespace UnityEngine.CoreModule
{
    public class Vector3
    {
        [JsonProperty("#Type")]
        public int _Type { get; set; }

        [JsonProperty("x")]
        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double X { get; set; }

        [JsonProperty("y")]
        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double Y { get; set; }

        [JsonProperty("z")]
        [PhoenixBinType(PhoenixTypeCode.Float)]
        public double Z { get; set; }

    }


    public class DumpNANPhoenixJsonHandling : JsonConverter<Vector3>
    {
        public override Vector3 ReadJson(JsonReader reader, Type objectType, Vector3 existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;
            JToken jt = JToken.Load(reader);

            var childs = jt.Children().ToArray();
            foreach (var item in jt.Children())
            {
                if (item.Path == "#Type") continue;
                if (item.First.Type == JTokenType.Object)
                {
                    return new Vector3()
                    {
                        _Type = childs[0].ToObject<int>(),
                        X = Double.NaN,
                        Y = Double.NaN,
                        Z = Double.NaN
                    };
                }
            }

            return (Vector3)jt.ToObject(typeof(Vector3));
        }

        public override void WriteJson(JsonWriter writer, Vector3 value, JsonSerializer serializer)
        {
            if (Double.IsNaN(value.X))
            {
                //var js = new JsonSerializer();
                //foreach (var s in serializer.Converters)
                //{
                //    if (s is DumpNANPhoenixJsonHandling) continue;
                //    js.Converters.Add(s);
                //}
                var s = new DumpVector3()
                {
                    _Type = value._Type
                };
                serializer.Serialize(writer, s);
            }
            else
            {
                serializer.Serialize(writer, new FakeVector3(value));
            }
        }

        public class FakeVector3
        {
            public FakeVector3() { }
            public FakeVector3(Vector3 vector)
            {
                _Type = vector._Type;
                X = vector.X;
                Y = vector.Y;
                Z = vector.Z;
            }
            [JsonProperty("#Type")]
            public int _Type { get; set; }

            [JsonProperty("x")]
            public double X { get; set; }

            [JsonProperty("y")]
            public double Y { get; set; }

            [JsonProperty("z")]
            public double Z { get; set; }

        }

        public class DumpVector3
        {
            [JsonProperty("#Type")]
            public int _Type { get; set; }
            [JsonProperty("x")]
            public DumpNumber X { get; set; } = new DumpNumber();

            [JsonProperty("y")]
            public DumpNumber Y { get; set; } = new DumpNumber();

            [JsonProperty("z")]
            public DumpNumber Z { get; set; } = new DumpNumber();
        }
        public class DumpNumber
        {
            [JsonProperty("_@number")]
            public string Number { get; set; } = "NaN";
        }
    }


}
