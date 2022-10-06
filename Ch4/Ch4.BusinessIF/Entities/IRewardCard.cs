using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.DomainIF.Entities
{
    public interface IRewardCard
    {
        int RewardPoints { get; }
        void CalculateRewardPoints(decimal amount, decimal balance);
    }

}
