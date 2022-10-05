using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.DomainIF.Services
{
    public interface IAccountService
    {
        void AddTransactionToAccount(
            string uniqueAccountName,
            decimal transactionAmount);
    }
}
