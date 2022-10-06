using Ch4.DomainConcrete.Entities;
using Ch4.DomainConcrete.Services;
using Ch4.DomainIF.Entities;
using Ch4.DomainIF.Repositories;
using Ch4Test.DomainIF.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Ch4Test.Tests
{
    [TestClass]
    public class AccountServiceTests
    {
        private Mock<IAccount> _account;
        private Mock<IAccountRepository> _accountRepository;
        private AccountService _accountService;

        [TestInitialize]
        public void Setup()
        {
            _account = new Mock<IAccount>();
            _accountRepository = new Mock<IAccountRepository>();
            _accountService = new AccountService(_accountRepository.Object);
        }

        [TestMethod]
        public void AddingTransactionToAccountDelegatesToAccountInstance()
        {
            var account = new Account();
            _accountRepository.Setup(r => r.GetByName("Trading Account")).Returns(account);
            _accountService.AddTransactionToAccount("Trading Account", 200m);
            Assert.AreEqual(200m, account.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void リポジトリがNull()
        {
            var sut = new AccountService(null);
            sut.AddTransactionToAccount("Trading Account", 200m);
        }

        [TestMethod]
        public void 該当するAccountが存在しない()
        {
            _accountService.AddTransactionToAccount("Trading Account", 200m);
        }

        [TestMethod]
        public void Accountのトランザクション処理でエラーが発生する()
        {
            _account.Setup(r => r.AddTransaction(200m)).Throws<DomainException>();
            _accountRepository.Setup(r => r.GetByName("Trading Account")).Returns(_account.Object);
            try
            {
                _accountService.AddTransactionToAccount("Trading Account", 200m);
            }
            catch (ServiceException e)
            {
                Assert.IsInstanceOfType(e.InnerException, typeof(DomainException));
            }
        }
    }
}