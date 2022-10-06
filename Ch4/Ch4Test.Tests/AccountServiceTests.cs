using Ch4.DomainConcrete;
using Ch4.DomainConcrete.Entities;
using Ch4.DomainConcrete.Services;
using Ch4.DomainIF.Entities;
using Ch4.DomainIF.Repositories;
using Ch4.DomainIF.Services;
using Ch4Test.DomainIF.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Ch4Test.Tests
{
    [TestClass]
    public class AccountServiceTests
    {
        private Mock<IAccountRepository> _accountRepository;
        private AccountService _accountService;

        [TestInitialize]
        public void Setup()
        {
            _accountRepository = new Mock<IAccountRepository>();
            _accountService = new AccountService(_accountRepository.Object);
        }

        [TestMethod]
        public void 継承されたアカウントでのトランザクション追加テスト()
        {
            var account = Factories.CreateAccount(AccountType.Bronze);
            _accountRepository.Setup(r => r.GetByName("Trading Account")).Returns(account);
            _accountService.AddTransactionToAccount("Trading Account", 200m);
            Assert.AreEqual(200m, account.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AccountRepositoryがNullのテスト()
        {
            var sut = new AccountService(null);
            sut.AddTransactionToAccount("Trading Account", 200m);
        }

        [TestMethod]
        public void 該当するAccountが存在しないテスト()
        {
            _accountService.AddTransactionToAccount("Trading Account", 200m);
        }

        [TestMethod]
        public void Accountのトランザクション処理でエラーが発生するテスト()
        {
            //var account = new FakeAccount();
            var account = new Mock<IAccount>();
            account.Setup(a => a.AddTransaction(200m)).Throws<DomainException>();
            _accountRepository.Setup(r => r.GetByName("Trading Account")).Returns(account.Object);
            try
            {
                _accountService.AddTransactionToAccount("Trading Account", 200m);
            }
            catch (ServiceException e)
            {
                Assert.IsInstanceOfType(e.InnerException, typeof(DomainException));
            }
        }
        [TestMethod]
        public void Bronzeアカウントのポイント動作確認()
        {
            var account = Factories.CreateAccount(AccountType.Bronze);
            _accountRepository.Setup(r => r.GetByName("Trading Account")).Returns(account);
            _accountService.AddTransactionToAccount("Trading Account", 100m);
            Assert.AreEqual(5, account.RewardsPoint);
        }
    }

    internal class FakeAccount : AccountBase
    {
        public override void AddTransaction(decimal amount)
        {
            throw new DomainException();
        }

        public override int CalculateRewardPoints(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}