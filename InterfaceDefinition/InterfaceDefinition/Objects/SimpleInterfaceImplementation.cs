using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDefinition.Objects
{
    internal class SimpleInterfaceImplementation : ISimpleInterface
    {
        private int _encapsulatedInteger;
        public string ThisStringPropertyNeedsImplementingToo 
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); 
        }

        public int ThisIntegerPropertyOnlyNeedsGetter
        {
            get => _encapsulatedInteger;
        }

        public event EventHandler<EventArgs> InterfacesCanContainEventsToo = delegate { };
        public void ThisMethodRequiresImplementation()
        {
            throw new NotImplementedException();
        }
    }
}
