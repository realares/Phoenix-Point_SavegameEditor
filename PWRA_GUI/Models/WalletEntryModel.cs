using PhoenixPoint.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWRA_GUI.Models
{
    public class WalletEntryModel
    {
        private ResourceUnit _Data;

        public WalletEntryModel(ResourceUnit unit)
        {
            this._Data = unit;
        }

        public ResourceUnit Data => _Data;

        
    }
}
