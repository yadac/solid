using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDefinition.Objects
{
    public interface ISimpleInterface
    {
        void ThisMethodRequiresImplementation();

        string ThisStringPropertyNeedsImplementingToo
        {
            get;
            set;
        }

        int ThisIntegerPropertyOnlyNeedsGetter
        {
            get;
        }

        event EventHandler<EventArgs> InterfacesCanContainEventsToo;
    }
}
