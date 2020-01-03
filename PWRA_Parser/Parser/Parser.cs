using Base;
using PP_Parser.Parser.Binary;
using PP_Parser.Parser.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Parser.Parser
{
    public class Parser
    {
        #region Singleton
        private static Lazy<Parser> _Instance = new Lazy<Parser>(() => new Parser());
        public static Parser Instance = _Instance.Value;

        private Parser() { }
        #endregion

        public bool EnshueBinCompatibility(Stream stream)
        {
            stream.Position = 0;
            byte[] data1 = new byte[stream.Length];
            stream.Read(data1, 0, data1.Length);
            stream.Position = 0;

            byte[] data2;
            using (var memStream = new MemoryStream(data1.Length))
            {
                BinWriter.Instance.Write(memStream, SaveGame.Instance);
                data2 = memStream.ToArray();
            }
            
            if (data1.Length != data2.Length)
                return false;

            return data1.SequenceEqual(data2);
          
        }

        public enum LoadResultEnum
        {
            notset,
            OK,
            NotCompatible
        }


        public LoadResultEnum Load(string path)
        {
            var info = new FileInfo(path);
            var lowerExtension = info.Extension.ToLower();

            Stream stream = null;
            LoadResultEnum result = LoadResultEnum.OK;

            try
            {
                if (lowerExtension.StartsWith(".z"))
                {
                    stream = new MemoryStream();
                    using (var fileStream = File.OpenRead(path))
                    {
                        using (var gzip = new GZipStream(fileStream, CompressionMode.Decompress, false))
                        {
                            gzip.CopyTo(stream);
                        }
                        stream.Position = 0;
                    }
                }
                else
                {
                    stream = File.OpenRead(path);
                }

                switch (info.Extension.ToLower())
                {
                    case ".sav":
                    case ".zsav":
                        BinParser.Instance.Load(stream);
                        if (!EnshueBinCompatibility(stream))
                            result = LoadResultEnum.NotCompatible;
                        break;

                    case ".jsav":
                        JsonParser.Instance.Load(stream);
#if DEBUG
                        JsonParser.Instance.TestReadWrite(path);
#endif
                        break;

                    case ".zjsav":
                        JsonParser.Instance.Load(stream);
                        break;

                    default:
                        break;
                }
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                    stream.Dispose();
                    stream = null;
                }
            }


            return result;
        }

        public void Save(string path)
        {
            var info = new FileInfo(path);
            var lowerExtension = info.Extension.ToLower();

            if (info.Exists)
                info.Delete();

            var savegame = SaveGame.Instance;
#if !DEBUG
            var meta = Eval.Evaluation.Instance.SavegameMetaData;
            if (meta != null)
            {
                Eval.Evaluation.Instance.SavegameMetaData.Name = info.Name;
                Eval.Evaluation.Instance.SavegameMetaData.UserSetName = info.Name;
            }
#endif

            using (var memStream = new MemoryStream())
            {
                switch (info.Extension.ToLower())
                {
                    case ".sav":
                    case ".zsav":
                        BinWriter.Instance.Write(memStream, SaveGame.Instance);
                        break;

                    case ".jsav":
                    case ".zjsav":
                        JsonParser.Instance.Save(memStream, SaveGame.Instance);
                        break;

                    default:
                        return;
                }

                using (var fileStream = File.OpenWrite(path))
                {
                    memStream.Position = 0;
                    if (lowerExtension.StartsWith(".z"))
                    {
                        using (var gzip = new GZipStream(fileStream, CompressionMode.Compress, false))
                        {
                            memStream.CopyTo(gzip);
                        }
                    }
                    else
                    {
                        memStream.CopyTo(fileStream);
                    }
                }
            }
        }
    }
}
