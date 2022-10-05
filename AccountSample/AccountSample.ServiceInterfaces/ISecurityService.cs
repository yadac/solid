using System;

namespace AccountSample.ServiceInterfaces
{
    public interface ISecurityService
    {
        void ChangeUserPassword(Guid userId, string pass);
    }
}
