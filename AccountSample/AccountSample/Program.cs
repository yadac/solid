using AccountSample.ServiceInterfaces;
using SimpleDependency;
using System;

namespace AccountSample.Controllers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var controller = new AccountController(
                new SecurityServiceMock());
            controller.ChangePassword(new Guid(), null);
            Console.ReadKey();
        }
    }

    internal class SecurityServiceMock : ISecurityService
    {
        public void ChangeUserPassword(Guid userId, string pass)
        {
            Console.WriteLine("[mock] change password");
        }
    }
}
