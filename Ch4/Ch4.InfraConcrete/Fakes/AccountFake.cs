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
        private AccountBase _account;
        public AccountFake(AccountBase account)
        {
            _account = account;
        }
        public AccountBase GetByName(string name)
        {
            return _account;
        }
    }
}
