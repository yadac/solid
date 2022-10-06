using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch4.DomainIF.Entities;

namespace Ch4.DomainConcrete.Entities
{
    internal class BronzeRewardCard : IRewardCard
    {
        private int AmountRate = 20;
        public int RewardPoints { get; private set; }

        public void CalculateRewardPoints(decimal amount, decimal balance)
        {
            RewardPoints += Math.Max((int)decimal.Floor(amount / AmountRate),0);
        }
    }
}
