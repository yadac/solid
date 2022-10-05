using AccountSample.Domain;
using System;

namespace AccountSample.DomainRepositories
{
    internal class UserRepository : IUserRepository
    {
        public string GetById(Guid userId)
        {
            return "user1";
        }
    }
}
