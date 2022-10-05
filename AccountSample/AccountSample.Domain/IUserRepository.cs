using System;

namespace AccountSample.Domain
{
    public interface IUserRepository
    {
        string GetById(Guid userId);
    }
}
