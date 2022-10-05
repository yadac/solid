using Ch4.DomainIF.Entities;
using Ch4.DomainIF.Services;
using Ch4.DomainIF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.DomainConcrete.Services
{
    public class AccountService : IAccountService
    {
        private IAccount _account;
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public void AddTransactionToAccount(
            string uniqueAccountName,
            decimal transactionAmount)
        {
            _account = _accountRepository.GetByName(uniqueAccountName);
            _account.AddTransaction(transactionAmount);
        }
    }
}
