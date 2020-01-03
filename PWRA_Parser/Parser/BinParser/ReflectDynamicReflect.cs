using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Parser.BinParser
{
    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class DynamicReflectAttribute : Attribute
    {

        // This is a positional argument
        public DynamicReflectAttribute()
        {
        }

    }

}
