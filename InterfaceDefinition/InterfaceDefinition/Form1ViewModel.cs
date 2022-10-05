using InterfaceDefinition.Objects;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VB;

namespace InterfaceDefinition
{
    internal class Form1ViewModel
    {
        private IUserReposotiry _userReposotiry;
        private IFluentIF _fluentIF;

        public Form1ViewModel()
            : this(new UserRepository(), new FluentClient())
        {
        }

        public Form1ViewModel(
            IUserReposotiry userReposotiry, IFluentIF fluentIF)
        {
            _userReposotiry = userReposotiry;
            this._fluentIF = fluentIF;
        }

        internal void Button1Click()
        {
            var user = _userReposotiry.GetByID(Guid.NewGuid());
            user.IncrementSessionTicket();
            Console.WriteLine($"The user's name is {user.Name}");
        }

        internal void Button2Click()
        {
            var device = Factories.GetDevice();
            Console.WriteLine(device.GetValue());
        }

        internal void Button3Click()
        {
            throw new NotImplementedException();
        }

        internal void Button4Click(bool isSwan)
        {
            IDuck d = new Duck(); 
            Swan s = new Swan();
            if (isSwan)
            {
                DoDuckLikeThings(s);
            }
            else
            {
                DoDuckLikeThings(d);
            }
        }

        private void DoDuckLikeThings(dynamic d)
        {
            d.Quack();
            _fluentIF.Method1()
                .Method2()
                .Method1();
        }
    }
}
