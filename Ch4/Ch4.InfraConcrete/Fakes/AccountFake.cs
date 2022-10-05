using Ch4.DomainIF.Entities;
using Ch4.DomainIF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.InfraConcrete.Fakes
{
    public class AccountFake : IAccountRepository
    {
        private IAccount _account;
        public AccountFake(IAccount account)
        {
            _account = account;
        }
        public IAccount GetByName(string name)
        {
            return _account;
        }
    }
}
