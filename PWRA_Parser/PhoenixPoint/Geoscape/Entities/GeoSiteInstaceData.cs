using Base.Utils;
using PhoenixPoint.Common.Levels.MapGeneration;
using PhoenixPoint.Geoscape.Entities.Sites;
using PP_Parser.Parser;
using UnityEngine.CoreModule;

namespace PhoenixPoint.Geoscape.Entities
{
    public class GeoSiteInstaceData : PhonixBaseObjectBaseValue
    {
        public PhoenixObjectID ActiveMission { get; set; }
        public PhoenixObjectID DiplomaticObjectiveFaction { get; set; }
        public PhoenixObjectID OwnerFactionDef { get; set; }
        public PhoenixEnum SiteType { get; set; }
        public PhoenixEnum State { get; set; }
        public Base.UI.LocalizedTextBind Name { get; set; }
        public Base.UI.LocalizedTextBind Motto { get; set; }
        public int RandomSeed { get; set; }
        public MapPlotInstanceData MapPlotInstanceData { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> Addons { get; set; }
        public PhoenixObjectID ItemStorage { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> TacUnits { get; set; }

        public PhoenixObjectID AlienBaseData { get; set; }
        public PhoenixObjectID HavenData { get; set; }
        public KnownPhoenixObjectID<GeoPhoenixBase.InstanceData> PhoenixBaseData { get; set; }
        public string EncounterID { get; set; }
        public PhoenixGenericCollection<PhoenixObjectID> FactionsData { get; set; }
        public PhoenixGenericCollection<string> SiteTags { get; set; }
        public bool CanBeRevealed { get; set; }
        public bool OverrideTransform { get; set; }

        public Vector3 Pos { get; set; }
        public Quaternion Rot { get; set; }

        public PhoenixObjectID Source { get; set; }

        public PhoenixObjectID TimingData { get; set; }
    }
}
