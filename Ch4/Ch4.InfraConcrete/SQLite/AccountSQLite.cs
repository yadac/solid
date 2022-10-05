using Ch4.DomainIF.Repositories;
using Ch4.DomainIF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.InfraConcrete.SQLite
{
    public class AccountSQLite : IAccountRepository
    {
        public IAccount GetByName(string name)
        {
            return null;
        }
    }
}
