using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDefinition.Objects
{
    public interface IUser
    {
        string Name { get; set; }
        void IncrementSessionTicket();
    }
}
