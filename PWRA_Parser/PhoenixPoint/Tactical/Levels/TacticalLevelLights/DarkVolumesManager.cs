using Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixPoint.Tactical.Levels.TacticalLevelLights
{
    public class DarkVolumesManager : PhonixBaseObjectBaseValue
    {
        public PhoenixGenericCollection<PhoenixGenericKeyValue<string, PhoenixGenericCollection<UnityEngine.CoreModule.Vector3>>> _revealedPositions { get; set; }
    }
}
