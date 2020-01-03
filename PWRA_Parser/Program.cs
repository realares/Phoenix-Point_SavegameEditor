using Base.Platforms;
using Base.Serialization.General;
using Base.Utils;
using PP_Parser.Parser;
using PP_Parser.Parser.Json;
using System.Collections.Generic;

namespace ConsoleApp8
{
    public class Program
    {

        static void Main(string[] args)
        {
            string pathRead = @"g:\test\death1_1.sav";
            string path = @"g:\test\writertest.sav";
            
            
            //BinParser.Instance.Load(pathRead);
            //var h = SaveGame.Instance;
            //new BinWriter().Write(h);


        }

        public class SaveGameTest
        {

            public int Version { get; set; }
            //public PhoenixObjectHolder Metadata { get; set; }
            //public PhoenixObjectHolder Contents { get; set; }
            //public PhoenixObjectHolder RuntimeDefs { get; set; }

        }
     
    }
}