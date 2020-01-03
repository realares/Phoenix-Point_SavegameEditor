using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Parser.Parser
{
    public enum PhoenixTypeCode : byte
    {
        Invalid = 0, 
        Empty = 1,   
        Bool = 2,    
        Byte = 3,
        Sbyte = 4,
        Char = 5,
        Short = 6,
        Ushort = 7,
        Int = 8,
        Uint = 9,
        Long = 10,
        Ulong = 11,
        Float = 12,    
        Double = 13,
        /// <summary>14 / 0x0E
        StringRef = 14,
        /// <summary>15 / 0x0F
        StringVal = 15,
        /// <summary>16 / 0x10
        Array = 16,
        /// <summary>17 / 0x11
        Object = 17,     
    }

}
