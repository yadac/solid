using Ch4.DomainIF.Entities;
using Ch4.DomainIF.Services;
using Ch4.DomainIF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch4Test.DomainIF.Exceptions;
using Ch4.DomainConcrete.Entities;

namespace Ch4.DomainConcrete.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            if (accountRepository == null)
            {
                throw new ArgumentNullException("accountRepository", "有効なリポジトリが必要です");
            }
            _accountRepository = accountRepository;
        }

        public void AddTransactionToAccount(
            string uniqueAccountName,
            decimal transactionAmount)
        {
            var account = _accountRepository.GetByName(uniqueAccountName);
            if (account != null)
            {
                try
                {
                    account.AddTransaction(transactionAmount);
                }
                catch (DomainException de)
                {
                    throw new ServiceException("Domain処理でエラーが発生", de);
                }
            }
        }
    }
}
