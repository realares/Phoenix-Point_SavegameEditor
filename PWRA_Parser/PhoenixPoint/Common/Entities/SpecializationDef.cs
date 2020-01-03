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
            Assault
        }
        const string HeavySpec = "4dd691ad-fc9d-2d54-e8c1-bc1b11228ec8";
        const string SniperSpec = "8b8510fe-f1cb-53b4-3a85-3a306c94e31f";
        const string AssaultSpec = "e5605970-efd8-c254-089f-4ccebc52ac66";

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
                    default:
                        break;
                }
            }
        }
    }
}
