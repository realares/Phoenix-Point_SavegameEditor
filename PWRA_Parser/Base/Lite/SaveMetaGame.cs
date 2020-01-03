using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Parser.Base.Lite
{

    public class SaveMetaGame
    {
        public int Version { get; set; }
        public PhoenixTypDefLite Metadata { get; set; }
        public PhoenixTypDefLite Contents { get; set; }
        public PhoenixTypDefLite RuntimeDefs { get; set; }

    }
}
