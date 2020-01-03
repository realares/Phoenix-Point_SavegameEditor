using Base;
using Base.Core;
using Base.Serialization.General;
using Base.UI;
using Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;
using Base.Platforms;

namespace PP_Parser.Parser
{
    public class SubTyper
    {
        private static Lazy<SubTyper> _Instance = new Lazy<SubTyper>(()=>new SubTyper());
        public static SubTyper Instance = _Instance.Value;

        private SubTyper() 
        {
            _valueTypeMapping = new Dictionary<int, Type>();
            _missingTypeMapping = new Dictionary<int, String>();
        }

        private Dictionary<int, Type> _valueTypeMapping;
        private Dictionary<int, String> _missingTypeMapping;

        public void Clear()
        {
            _valueTypeMapping.Clear();
            _missingTypeMapping.Clear();
        }

        public bool TryGetValue(int key, out Type value)
        {
            return _valueTypeMapping.TryGetValue(key, out value);
        }

        public void AddMapping(int id) { }

        public void AddMapping(TypeData item)
        {
            string tname = item.TypeName
                .Replace("Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", "PP_Parser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")
                .Replace("UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", "PP_Parser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")
                .Replace("System.Object, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "PP_Parser.Base.PhoenixObjectID, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");

            if (tname.StartsWith("System.Collections.Generic.List`1") || tname.StartsWith("System.Collections.Generic.LinkedList`1"))
            {
                {
                    int MidItemStart = tname.IndexOf('[');
                    int MidItemEnd = tname.LastIndexOf(']');
                    string MidItem = tname.Substring(MidItemStart, MidItemEnd - MidItemStart + 2);
                    tname = "PP_Parser.Base.PhoenixGenericCollection`1" + MidItem + ", Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null";
                }
            }

            else if (tname.StartsWith("System.Collections.Generic.Dictionary`2[")
                || tname.StartsWith("System.Collections.Generic.KeyValuePair`2"))
            {
                return;
            }
            else if (tname.StartsWith("System.DateTime, "))
            {
                _valueTypeMapping.Add(item.Id, typeof(PhoenixDataTime));
                return;
            }
            else if (tname.StartsWith("System.Single[],"))
            {
                _valueTypeMapping.Add(item.Id, typeof(PhoenixGenericArray<Double>));
                return;
            }
            else if (tname.StartsWith("System.TimeSpan,"))
            {
                _valueTypeMapping.Add(item.Id, typeof(PhoenixTimeSpan));
                return;
            }

            else if (tname.StartsWith("Base.UI.LocalizedTextBind[],"))
            {
                _valueTypeMapping.Add(item.Id, typeof(PhoenixGenericArray<LocalizedTextBind>));
                return;
            }

            else if (tname.StartsWith("PhoenixPoint.Tactical.Levels.Destruction.Destructable+Storage[],"))
            {
                _valueTypeMapping.Add(item.Id, typeof(PhoenixGenericArray<PhoenixEnum>));
                return;
            }
            else if (tname.StartsWith("PhoenixPoint.Common.Entities.GameTags.GameTagDef[],"))
            {
                _valueTypeMapping.Add(item.Id, typeof(PhoenixGenericArray<PhoenixObjectID>));
                return;
            }
            else if (tname.StartsWith("Base.Defs.ObjectDef[],"))
            {
                _valueTypeMapping.Add(item.Id, typeof(PhoenixGenericArray<PhoenixObjectID>));
                return;
            }
            else if (tname.StartsWith("Base.Platforms.EntitlementDef[],"))
            {
                _valueTypeMapping.Add(item.Id, typeof(PhoenixGenericArray<EntitlementDef>));
                return;
            }
            else if (tname.StartsWith("PhoenixPoint.Common.Core.AICoreType[]"))
            {
                _valueTypeMapping.Add(item.Id, typeof(PhoenixGenericArray<PhoenixEnum>));
                return;
            }
            

            else if (tname.StartsWith("PhoenixPoint.Common.Entities.Characters.AbilityTrackSlot[],")
                || tname.StartsWith("PhoenixPoint.Tactical.Entities.Abilities.TacticalAbilityDef[],")
                || tname.StartsWith("PhoenixPoint.Tactical.Entities.Equipments.TacticalItemDef[],")
                || tname.StartsWith("PhoenixPoint.Common.Entities.GameTags.GameTagDef[],")
                || tname.StartsWith("PhoenixPoint.Geoscape.Entities.GeoCharacter[],"))
            {
                _valueTypeMapping.Add(item.Id, typeof(PhoenixGenericArray<PhoenixObjectID>));
                return;
            }

            else if (tname.Contains("[*],"))
            {
                return;
            }

            else if (tname.Contains("[],"))
            {
                _valueTypeMapping.Add(item.Id, typeof(PhoenixGenericArray<PhoenixObjectID>));
                return;
            }

            var s = GetTypeByName(tname, typeof(PhonixBaseObjectBaseValue));
            if (s == null) s = GetTypeByName("PP_Parser." + tname, typeof(PhonixBaseObjectBaseValue));
            if (s != null)
            {
                _valueTypeMapping.Add(item.Id, s);
            }
            else
            {
                _missingTypeMapping.Add(item.Id, tname);
                Debug.WriteLine(item.TypeName);
            }
        }

        public string GetMissingType(int key)
        {
            if (_missingTypeMapping.TryGetValue(key, out string ret))
                return ret;
            return "not missing";
        }

        public void SetupJsonSubType()
        {

        }

        public bool TryGetKey(Type type, out int key)
        {
            if (!_valueTypeMapping.ContainsValue(type))
            {
                key = -1;
                return false;
            }

            key = _valueTypeMapping.First(x => x.Value == type).Key;
            return true;

        }
        public int GetKey(Type type)
        {
            if (!_valueTypeMapping.ContainsValue(type))
            {
                return -1;
            }
            return _valueTypeMapping.First(x => x.Value == type).Key;
        }


        public static Type GetTypeByName(string typeName, Type parentType)
        {
            if (typeName == null)
                return null;

            var insideAssembly = parentType.GetTypeInfo().Assembly;

            var typeByName = insideAssembly.GetType(typeName);

            if (typeByName == null)
            {
                var searchLocation =
                    parentType.FullName.Substring(0, parentType.FullName.Length - parentType.Name.Length);
                typeByName = insideAssembly.GetType(searchLocation + typeName, false, true);
            }
            if (typeByName == null)
            {
                typeByName = Type.GetType(typeName);
            }
            return typeByName;
        }
    }
}
