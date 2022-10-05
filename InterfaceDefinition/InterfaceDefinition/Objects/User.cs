using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDefinition.Objects
{
    internal class User : IUser
    {
        public User(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    
        public Guid Id { get; set; }
        public string Name { get; set; }

        public void IncrementSessionTicket()
        {
            throw new NotImplementedException();
        }
    }
}
