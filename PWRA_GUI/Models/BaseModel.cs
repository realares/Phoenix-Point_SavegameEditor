using PhoenixPoint.Geoscape.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PhoenixPoint.Common.Entities.SpecializationDef;

namespace PWRA_GUI.Models
{
    public class BaseModel
    {
        private GeoSiteInstaceData _Data;

        public BaseModel(GeoSiteInstaceData geoCharacter) 
        {
            this._Data = geoCharacter;
        }

        public GeoSiteInstaceData Data => _Data;


    }
}
