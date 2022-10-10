using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3Composite
{
    public interface IComponent
    {
        void Something();
    }

    internal sealed class Leaf : IComponent
    {
        public void Something()
        {
        }
    }
    internal sealed class CompositeComponent : IComponent
    {
        // 色んなIComponentを持つ
        private ICollection<IComponent> _components;

        public CompositeComponent()
        {
            _components = new List<IComponent>();
        }

        public void AddComponent(IComponent component)
        {
            _components.Add(component);
        }
        public void RemoveComponent(IComponent component)
        {
            _components.Remove(component);
        }

        public void Something()
        {
            foreach (var component in _components)
            {
                component.Something();
            }
        }
    }
}
