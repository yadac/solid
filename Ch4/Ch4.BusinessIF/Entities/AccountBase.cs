using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.DomainIF.Entities
{
    public abstract class AccountBase
    {
        public decimal Balance { get; private set; }
        public int RewardPoints { get; private set; }
                
        public virtual void AddTransaction(decimal amount)
        {
            RewardPoints += CalculateRewardPoints(amount);
            Balance += amount;
        }
        public abstract int CalculateRewardPoints(decimal amount);
    }

    public enum AccountType
    {
        Bronze,
        Silver,
        Gold,
        Pratinum
    }
}
