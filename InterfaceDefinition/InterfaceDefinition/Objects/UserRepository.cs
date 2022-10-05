using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDefinition.Objects
{
    internal class UserRepository : IUserReposotiry
    {
        private ICollection<User> _users;
        public UserRepository()
        {
            _users = new List<User>
            {
                new User(new Guid(), "Imanaka"),
                new User(new Guid(), "Yamamoto"),
                new User(new Guid(), "Kawakami"),
                new User(new Guid(), "Maeda")
            };
        }

        public IUser GetByID(Guid id)
        {
            IUser user = _users.SingleOrDefault(u => u.Id == id);
            if (user == null)
            {
                user = new NullUser();
                //throw new KeyNotFoundException("not found");
            }
            return user;
        }
    }
}
