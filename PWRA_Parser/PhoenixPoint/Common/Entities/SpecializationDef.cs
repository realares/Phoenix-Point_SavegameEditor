using Newtonsoft.Json;
using PP_Parser.Parser;


namespace PhoenixPoint.Common.Entities
{
    public class SpecializationDef : PhoenixTagDef
    {
        public enum SpecializatioEnum
        {
            unkown,
            Heavy,
            Sniper,
            Assault,
            Technician,
            Berserker,
            Priest,
            Infiltrator,
            Unknown_1,
            Unknown_2,
            Unknown_3, 
            Unknown_4,
        }
        const string HeavySpec = "4dd691ad-fc9d-2d54-e8c1-bc1b11228ec8";
        const string SniperSpec = "8b8510fe-f1cb-53b4-3a85-3a306c94e31f";
        const string AssaultSpec = "e5605970-efd8-c254-089f-4ccebc52ac66";

        const string BerserkerSpec = "e2fd29c3-c35b-7794-1bab-55c3d816100a";
        const string Infiltrator2Spec = "87a04a51-ace1-9574-78a0-42c96f6cc04d";
        const string TechnicianSpec = "d7a34370-ec7f-bc94-ba44-29fbc058b2ee";
        const string PriestSpec = "bb2ce30b-8b93-2614-9986-3b394824c743";


        [JsonIgnore]
        public SpecializatioEnum Specialization
        {
            get
            {
                switch (this.SerializationGuid)
                {
                    case HeavySpec: return SpecializatioEnum.Heavy;
                    case SniperSpec: return SpecializatioEnum.Sniper;
                    case AssaultSpec: return SpecializatioEnum.Assault;
                    case BerserkerSpec: return SpecializatioEnum.Berserker;
                    case Infiltrator2Spec: return SpecializatioEnum.Infiltrator;
                    case TechnicianSpec: return SpecializatioEnum.Technician;
                    case PriestSpec: return SpecializatioEnum.Priest;
                    default:
                        return SpecializatioEnum.unkown;
                        
                }
            }
            set
            {
                switch (value)
                {
                    case SpecializatioEnum.unkown:
                        break;
                    case SpecializatioEnum.Heavy:
                        this.SerializationGuid = HeavySpec;
                        break;
                    case SpecializatioEnum.Sniper:
                        this.SerializationGuid = SniperSpec;
                        break;
                    case SpecializatioEnum.Assault:
                        this.SerializationGuid = AssaultSpec;
                        break;
                    case SpecializatioEnum.Infiltrator:
                        this.SerializationGuid = Infiltrator2Spec;
                        break;
                    case SpecializatioEnum.Technician:
                        this.SerializationGuid = TechnicianSpec;
                        break;
                    case SpecializatioEnum.Berserker:
                        this.SerializationGuid = BerserkerSpec;
                        break;
                    case SpecializatioEnum.Priest:
                        this.SerializationGuid = PriestSpec;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
