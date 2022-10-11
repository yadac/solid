using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7LSP
{
    public class Entity
    {
        public Guid ID { get; private set; }
        public string Name { get; private set; }
    }

    public class User : Entity
    {
        public string EmailAddress { get; private set; }
        public DateTime DateOfBirth { get; private set; }
    }

    public class EntityRepository : IEntityRepository<Entity>
    {
        public Entity GetByID(Guid id)
        {
            return new Entity();
        }
    }

    public class UserRepository : IEntityRepository<User>, IEqualityComparer<Entity>
    {
        public bool Equals(Entity x, Entity y)
        {
            return x.ID == y.ID;
        }

        public User GetByID(Guid id)
        {
            return new User();
        }

        public int GetHashCode(Entity obj)
        {
            throw new NotImplementedException();
        }
    }

    public interface IEntityRepository<T> where T : Entity
    {
        T GetByID(Guid id);
    }
}
