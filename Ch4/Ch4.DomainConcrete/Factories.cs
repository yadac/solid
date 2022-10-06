using Ch4.DomainConcrete.Entities;
using Ch4.DomainIF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.DomainConcrete
{
    public class Factories
    {
        public static Account CreateAccount(AccountType type)
        {
            Account account = null;
            switch (type)
            {
                case AccountType.Bronze:
                    account = new Account(new BronzeRewardCard());
                    break;
                //case AccountType.Silver:
                //    account = new SilverAccount();
                //    break;
                //case AccountType.Gold:
                //    account = new GoldAccount();
                //    break;
                //case AccountType.Pratinum:
                //    account = new PratinumAccount();
                //    break;
                default:
                    break;
            }
            return account;
        }

    }
}
