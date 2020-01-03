using PP_Parser.Parser;

namespace PhoenixPoint.Common.Levels.MapGeneration
{
    public class MapPlotInstanceData : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID MapPlotDef { get; set; }
        public PhoenixGenericCollection<MapParcelInstance> ParcelInstances { get; set; }
    }
}
