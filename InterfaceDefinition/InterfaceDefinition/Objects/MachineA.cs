using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDefinition.Objects
{
    internal class MachineA : IDevice
    {
        public string GetValue()
        {
            return 1000 + "yen";
        }
    }
}
