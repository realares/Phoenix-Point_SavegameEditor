using Base;
using Base.Core;
using Base.Platforms;
using Base.Serialization.General;
using Base.UI;
using Base.Utils;
using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PhoenixPoint.Common.Entities.Characters;
using PhoenixPoint.Common.Levels.ActorDeployment;
using PhoenixPoint.Geoscape.Entities;
using PhoenixPoint.Geoscape.Entities.Research;
using PhoenixPoint.Tactical.Entities;
using PP_Parser;
using PP_Parser.Base;
using PP_Parser.Base.Lite;
using PP_Parser.BinParser;
using PP_Parser.Parser;
using PP_Parser.Parser.BinParser;
using PP_Parser.Parser.JsonParser;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Program
    {

        static void Main(string[] args)
        {
            string pathRead = @"g:\test\death1_1.sav";
            string path = @"g:\test\writertest.sav";
            
            
            BinParser.Instance.Load(pathRead);
            var h = SaveGame.Instance;
            new BinWriter().Write(h);


        }

        public void test()
        {
            var o = new SaveGame()
            {
                Version = 1,
                Metadata = new PhoenixObjectHolder()
                {
                    Types = new List<TypeData>()
                    {
                        new TypeData()
                        {
                            Id = 1,
                            _Type = 1,
                            TypeName = "Base.Serialization.General.TypeData, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null",
                            Version = 1
                        },
                        new TypeData()
                        {
                            Id = 2,
                            _Type = 1,
                            TypeName = "Base.Serialization.PPSavegameMetaData, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null",
                            Version = 1
                        },
                        new TypeData()
                        {
                            Id = 3,
                            _Type = 1,
                            TypeName = "Base.Serialization.PPGameId, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null",
                            Version = 1
                        },
                        new TypeData()
                        {
                            Id = 4,
                            _Type = 1,
                            TypeName = "Base.Utils.UnityDateTime, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null",
                            Version = 1
                        },
                        new TypeData()
                        {
                            Id = 5,
                            _Type = 1,
                            TypeName = "System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
                            Version = 1
                        },
                        new TypeData()
                        {
                            Id = 6,
                            _Type = 1,
                            TypeName = "Base.Serialization.TacticalSaveDependency, Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null",
                            Version = 1
                        },
                        new TypeData()
                        {
                            Id = 7,
                            _Type = 1,
                            TypeName = "Base.Platforms.EntitlementDef[], Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null",
                            Version = 1
                        },
                        new TypeData()
                        {
                            Id = 8,
                            _Type = 1,
                            TypeName = "System.Collections.Generic.List`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
                            Version = 1
                        }
                    },
                    Objects = new List<PhoenixBaseObjects>()
                     {
                         new PhoenixBaseObjects()
                         {
                              ObjectID = 1,
                              TopLevel =true,
                              ObjectValue=new Base.Serialization.PPSavegameMetaData()
                              {
                                    _Type = 2,
                                    GameId =new Base.Serialization.PPGameId()
                                    {
                                        _Type = 3,
                                        GameStartedIndex =2,
                                        GuidString="ee8f4732-eabc-4dbb-8215-81435bb67564"
                                    },
                                    LocationName = "Geoscape",
                                    UserSetName = "Neu1",
                                    EnabledDlc = new PhoenixGenericArray<EntitlementDef>
                                    {
                                        _Type = 7,
                                        ArrayDimensions = new PhoenixGenericCollection<int>()
                                        {
                                            _Type=8,
                                                CollectionValues= new List<int>()
                                                {
                                                    0
                                                }
                                        },
                                        CollectionValues = new List<EntitlementDef>()
                                        {

                                        }
                                    },
                                    SaveCreated = new UnityDateTime()
                                    {
                                        DateTime = new PhoenixDataTime()
                                        {
                                            _Type = 4,
                                            Kind = new PhoenixEnum()
                                            {
                                                EnumName = "Local",
                                                EnumValue = 2,
                                            },
                                            Ticks = new PhoenixDataTimeTicks()
                                            {
                                                Ticks = "637133905857466170"
                                            }
                                        }
                                    }

                              }
                         }
                     }

                }
            };

        }

        public class SaveGameTest
        {

            public int Version { get; set; }
            //public PhoenixObjectHolder Metadata { get; set; }
            //public PhoenixObjectHolder Contents { get; set; }
            //public PhoenixObjectHolder RuntimeDefs { get; set; }

        }
        public static void Load(string sourcePath)
        {
            JsonParser.Instance.Load(sourcePath);
        }

        public static void Save(string dstPath)
        {
            JsonParser.Instance.Save(dstPath);
        }
        public static void TestReadWrite(string sourcePath, string dstPath)
        {
            JsonParser.Instance.TestReadWrite(sourcePath, dstPath);
        }

     
    }
}