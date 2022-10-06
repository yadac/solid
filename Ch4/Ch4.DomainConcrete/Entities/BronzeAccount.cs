using Ch4.DomainIF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.DomainConcrete.Entities
{
    internal class BronzeAccount : AccountBase
    {
        private const int AmountRate = 20;

        public override int CalculateRewardPoints(decimal amount)
        {
            return (int)decimal.Floor(amount / AmountRate);
        }
    }
}
