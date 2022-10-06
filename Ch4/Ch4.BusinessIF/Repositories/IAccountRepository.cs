using Ch4.DomainIF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.DomainIF.Repositories
{
    public interface IAccountRepository
    {
        IAccount GetByName(string name);
    }
}
