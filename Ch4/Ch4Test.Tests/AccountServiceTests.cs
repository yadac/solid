using Ch4.DomainConcrete.Entities;
using Ch4.DomainConcrete.Services;
using Ch4.DomainIF.Entities;
using Ch4.DomainIF.Repositories;
using Ch4.InfraConcrete.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
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
            var mock = new Mock<IAccountRepository>();
            mock.Setup(r => r.GetByName("Trading Account")).Returns(account);
            var sut = new AccountService(mock.Object);
            // Act
            sut.AddTransactionToAccount("Trading Account", 200m);
            // Assert
            Assert.AreEqual(200m, account.Balance);
        }
    }
}
