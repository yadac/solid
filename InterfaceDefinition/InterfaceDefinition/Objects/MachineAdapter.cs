using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VB;

namespace InterfaceDefinition.Objects
{
    internal class MachineAdapter : IDevice
    {
        private VB01 _vb;

        public MachineAdapter(VB01 vb)
        {
            _vb = vb;
        }
        public string GetValue()
        {
            return _vb.GetValue() + "yen";
        }
    }
}
