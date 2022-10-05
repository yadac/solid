using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDefinition.Objects
{
    internal class ExplicitInterfaceImplementation : ISimpleInterface
    {
        private int _encapsulatedInteger;
        private event EventHandler<EventArgs> _encapsulatedEvent;

        public ExplicitInterfaceImplementation()
        {
            _encapsulatedInteger = 4;
        }

        void ISimpleInterface.ThisMethodRequiresImplementation()
        {
            _encapsulatedEvent(this, EventArgs.Empty);
        }

        public string ThisStringPropertyNeedsImplementingToo
        { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public int ThisIntegerPropertyOnlyNeedsGetter => 
            _encapsulatedInteger;

        public event EventHandler<EventArgs> InterfacesCanContainEventsToo
        {
            add { _encapsulatedEvent += value; }
            remove { _encapsulatedEvent -= value; }
        }

        public void ThisMethodRequiresImplementation()
        {
            throw new NotImplementedException();
        }
    }
}
