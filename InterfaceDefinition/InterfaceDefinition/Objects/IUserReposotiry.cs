using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDefinition.Objects
{
    internal interface IUserReposotiry
    {
        IUser GetByID(Guid id);
    }
}
