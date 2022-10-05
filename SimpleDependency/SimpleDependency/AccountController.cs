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

    public interface ISecurityService
    {
        void ChangeUserPassword(Guid userId, string pass);
    }
    internal class SecurityService : ISecurityService
    {
        private IUserRepository _userRepository;
        public SecurityService(IUserRepository userRepository)
        {
            if (userRepository == null)
            {
                throw new ArgumentNullException("userRepository");
            }
            _userRepository = userRepository;
        }
        public void ChangeUserPassword(Guid userId, string pass)
        {
            var user = _userRepository.GetById(userId);
        }
    }


    internal class UserRepository : IUserRepository
    {
        public string GetById(Guid userId)
        {
            return "user1";
        }
    }

    public interface IUserRepository
    {
        string GetById(Guid userId);
    }
}
