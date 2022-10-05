using AccountSample.ServiceInterfaces;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleDependency
{
    internal class AccountController
    {
        private readonly ISecurityService _securityService;
        public AccountController(ISecurityService securityService)
        {
            if (securityService == null)
            {
                throw new ArgumentNullException("securityService");
            }
            _securityService = securityService;
        }

        public void ChangePassword(Guid userId, string newPassword)
        {
            _securityService.ChangeUserPassword(userId, newPassword);
        }
    }
}
