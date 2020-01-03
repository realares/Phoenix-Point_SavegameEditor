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
                    PP_Parser.BinParser.BinParser.Instance.Load(stream);
                    break;

                case ".jsav":
                    JsonParser.JsonParser.Instance.Load(stream);
                    JsonParser.JsonParser.Instance.TestReadWrite(path, path + ".new");
                    break;

                case ".zjsav":
                    JsonParser.JsonParser.Instance.Load(stream);
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
    }
}
