using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8ISP
{
    public interface IUnautorized
    {
        IAuthorized Login(string name, string pass);
        void RequestPasswordReminder(string email);
    }

    public interface IAuthorized
    {
        void ChangePassword(string o, string n);
        void AddToBasket(Guid id);
        void Checkout();
        void Logout();
    }
}
