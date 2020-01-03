using PhoenixPoint.Geoscape.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PhoenixPoint.Common.Entities.SpecializationDef;

namespace PWRA_GUI.Models
{
    public class CharacterModel
    {
        private GeoCharacter _Data;

        public CharacterModel(GeoCharacter geoCharacter) 
        {
            this._Data = geoCharacter;
        }

        public GeoCharacter Data => _Data;


    }
}
