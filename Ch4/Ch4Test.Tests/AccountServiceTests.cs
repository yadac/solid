using Ch4.DomainConcrete.Entities;
using Ch4.DomainConcrete.Services;
using Ch4.InfraConcrete.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Ch4Test.Tests
{
    [TestClass]
    public class AccountServiceTests
    {
        [TestMethod]
        public void AddingTransactionToAccountDelegatesToAccountInstance()
        {
            // Arrange
            var account = new Account();
            var fakeRepository = new AccountFake(account);
            var sut = new AccountService(fakeRepository);
            // Act
            sut.AddTransactionToAccount("Trading Account", 200m);
            // Assert
            Assert.AreEqual(200m, account.Balance);
        }
    }
}
