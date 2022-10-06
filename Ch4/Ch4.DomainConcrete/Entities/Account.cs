using Ch4.DomainIF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.DomainConcrete.Entities
{
    public class Account : IAccount
    {
        private readonly IRewardCard _rewardCard;
        public int RewardsPoint
        {
            get { return _rewardCard.RewardPoints; }
        }

        public Account(IRewardCard rewardCard)
        {
            _rewardCard = rewardCard;
        }

        public decimal Balance { get; private set; } = 0;

        public void AddTransaction(decimal amount)
        {
            _rewardCard.CalculateRewardPoints(amount, Balance);
            Balance += amount;
        }
    }
}
