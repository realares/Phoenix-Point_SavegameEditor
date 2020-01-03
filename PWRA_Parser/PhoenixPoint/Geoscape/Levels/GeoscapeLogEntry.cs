using Base.Core;
using PP_Parser.Parser;

namespace PhoenixPoint.Geoscape.Levels
{
    public class GeoscapeLogEntry : PhonixBaseObjectBaseValue
    {
        public Base.UI.LocalizedTextBind Text { get; set; }
        public PhoenixGenericArray<Base.UI.LocalizedTextBind> Parameters { get; set; }
        public TimeUnit EventDate { get; set; }
        public bool HighPriority { get; set; }
    }
}
