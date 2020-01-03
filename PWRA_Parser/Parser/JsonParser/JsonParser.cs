﻿using Base;
using Newtonsoft.Json;
using PP_Parser.Base.Lite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Parser.Parser.JsonParser
{
    public class JsonParser
    {
        private static Lazy<JsonParser> _Instance = new Lazy<JsonParser>(()=>new JsonParser());
        public static JsonParser Instance = _Instance.Value;

        private JsonParser() { }
        public void Load(string path)
        {
            using (var fs = File.OpenRead(path))
                Load(fs);
        }

        public void Load(Stream stream)
        {

            SubTyper.Instance.Clear();

            var setting = new JsonSerializerSettings();
            setting.FloatParseHandling = FloatParseHandling.Double;

            using (var sr = new StreamReader(stream))
            {
                var all = sr.ReadToEnd();
                
                var Meta = Newtonsoft.Json.JsonConvert.DeserializeObject<SaveMetaGame>(all, setting);

                foreach (var item in Meta.Metadata.Types)
                    SubTyper.Instance.AddMapping(item);

                foreach (var item in Meta.Contents.Types)
                    SubTyper.Instance.AddMapping(item);

                foreach (var item in Meta.RuntimeDefs.Types)
                    SubTyper.Instance.AddMapping(item);

                var save = Newtonsoft.Json.JsonConvert.DeserializeObject<SaveGame>(all, setting);
                SaveGame.Instance = save;
            }
        }

        public void Save(string dstPath)
        {
            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new DecimalJsonConverter());
            // settings.Converters.Add(new muhconverter());
            settings.Formatting = Formatting.Indented;


            var ff = Newtonsoft.Json.JsonConvert.SerializeObject(SaveGame.Instance, settings);

            ff = ff
                .Replace(": []", ": [\r\n            ]")
                .Replace(": 0.0,", ": 0,")
                .Replace(": 0.0\r\n", ": 0\r\n")
                ;
            File.WriteAllText(dstPath, ff);
        }
       

        public void TestReadWrite(string sourcePath, string dstPath)
        {

            Save(dstPath);

            var s1 = File.ReadAllLines(sourcePath);
            var s2 = File.ReadAllLines(dstPath);
            int j = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i].Trim() != s2[j].Trim())
                {
                    if (s1[i].Trim() == "\"PrefabSource\": null," && s2[j].Trim().StartsWith("\"SerializationGuid\":"))
                    {
                        // All ok.. this is one i can not fix
                        // go ahead with i++                        
                        continue;
                    }

                    //

                    Debug.WriteLine($"Line:{i + 1}");
                    Debug.WriteLine($"{s1[i]}");
                    Debug.WriteLine($"{s2[j]}");
                    break;
                }
                j++;
            }
        }

    }
}
