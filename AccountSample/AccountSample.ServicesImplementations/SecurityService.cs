using AccountSample.Domain;
using AccountSample.ServiceInterfaces;
using System;

namespace AccountSample.ServicesImplementations
{
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
}
