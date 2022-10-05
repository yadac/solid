using Ch4.DomainIF.Entities;

namespace Ch4.DomainConcrete.Entities
{
    public class Account : IAccount
    {
        public decimal Balance { get; set; } = 0;

        public void AddTransaction(decimal transactionAmount)
        {
            Balance += transactionAmount;
        }
    }
}