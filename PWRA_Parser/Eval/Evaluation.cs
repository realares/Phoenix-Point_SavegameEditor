using Base.Serialization;
using PhoenixPoint.Geoscape.Entities;
using PhoenixPoint.Geoscape.Levels;
using PhoenixPoint.Tactical.Entities;
using PP_Parser.Parser;
using System;
using System.Collections.Generic;

namespace PP_Parser.Eval
{
    public class Evaluation
    {
        private static Lazy<Evaluation> _Instance = new Lazy<Evaluation>(()=>new Evaluation());
        public static Evaluation Instance = _Instance.Value;

        private Evaluation() { }

        private SaveGame save => SaveGame.Instance;

        public bool IsTacticalMap => OwnerDef == null;

        public bool IsGeoscapeMap => OwnerDef != null;

        public PPSavegameMetaData SavegameMetaData => save.Metadata.Objects.Find(x => (x.ObjectValue is PPSavegameMetaData)).ObjectValue as PPSavegameMetaData;

        public List<PhoenixBaseObjects> PhoenixTagDefs =>  save.Contents.Objects.FindAll(x => (x.ObjectValue is PhoenixTagDef));
        public PhoenixBaseObjects OwnerDef => PhoenixTagDefs.Find(x => ((PhoenixTagDef)x.ObjectValue).SerializationGuid == KnownDefs.PhoenixFactionDef);
        public PhoenixBaseObjects PlayerDef => PhoenixTagDefs.Find(x => ((PhoenixTagDef)x.ObjectValue).SerializationGuid == KnownDefs.PlayerFactionDef);

        #region Geoscape

        public List<PhoenixBaseObjects> AllGeoCharacter => save.Contents.Objects.FindAll(x => (x.ObjectValue is GeoCharacter));
        public List<PhoenixBaseObjects> AllGeoSites => save.Contents.Objects.FindAll(x => (x.ObjectValue is GeoSite));
        public List<PhoenixBaseObjects> AllWallets => save.Contents.Objects.FindAll(x => (x.ObjectValue is GeoFactionInstanceData));


        public List<PhoenixBaseObjects> PlayerGeoCharacters => AllGeoCharacter.FindAll(x => ((GeoCharacter)x.ObjectValue)._factionDef.ObjectID == OwnerDef.ObjectID);
        public List<PhoenixBaseObjects> PlayerBases => AllGeoSites.FindAll(x => ((GeoSite)x.ObjectValue).SerializationData.OwnerFactionDef.ObjectID == OwnerDef.ObjectID);
        public PhoenixBaseObjects Playerrwallets => AllWallets.Find(x => ((GeoFactionInstanceData)x.ObjectValue).FactionDef.ObjectID == PlayerDef.ObjectID);

        #endregion


        #region Tactiacal

        public List<TacticalActor> TacticalActors
        {
            get
            {
                List<TacticalActor> _result = new List<TacticalActor>();

                var TacCharacter = save.Contents.Objects.FindAll(x => (x.ObjectValue is TacticalActor));
                foreach (var car in TacCharacter)
                {
                    var val = car.ObjectValue as TacticalActor;

                    //if (val.SerializationData.MissionParticipant.EnumName != "Player")
                    //    continue;

                    //if (val.SerializationData.OverrideName == null)
                    //    continue;

                    _result.Add(val);
                }
                return _result;
            }
        }
        //public List<TacticalActor> AlienActors
        //{
        //    get
        //    {
        //        List<TacticalActor> _result = new List<TacticalActor>();

        //        var TacCharacter = save.Contents.Objects.FindAll(x => (x.ObjectValue is TacticalActor));
        //        foreach (var car in TacCharacter)
        //        {
        //            var val = car.ObjectValue as TacticalActor;

        //            if (val.SerializationData.MissionParticipant.EnumName == "Player")
        //                continue;

        //            if (val.SerializationData.OverrideName == null)
        //                continue;

        //            _result.Add(val);
        //        }
        //        return _result;
        //    }
        //}

        #endregion
    }
}
