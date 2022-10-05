using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VB;

namespace InterfaceDefinition.Objects
{
    internal class Factories
    {
        internal static IDevice GetDevice()
        {
            return new MachineAdapter(new VB01());
        }
    }
}
