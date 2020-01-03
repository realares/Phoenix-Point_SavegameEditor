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


        public void Load(string path)
        {
            var info = new FileInfo(path);
            var lowerExtension = info.Extension.ToLower();

            Stream stream;

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
                    break;

                case ".jsav":
                    JsonParser.Instance.Load(stream);
                    //JsonParser.Instance.TestReadWrite(path, path + ".new");
                    break;

                case ".zjsav":
                    JsonParser.Instance.Load(stream);
                    break;

                default:
                    return;
            }

            if (stream != null)
            {
                stream.Close();
                stream.Dispose();
                stream = null;
            }
        }

        public void Save(string path)
        {
            var info = new FileInfo(path);
            var lowerExtension = info.Extension.ToLower();

            if (info.Exists)
                info.Delete();

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
