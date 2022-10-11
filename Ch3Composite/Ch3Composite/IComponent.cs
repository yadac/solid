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

    public interface IComponentWithProperty
    {
        void Something();
        string MyProperty { get; set; }
    }

    public class ConcreteComponentWithProperty : IComponentWithProperty
    {
        public string MyProperty
        { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public void Something()
        {
            Console.WriteLine("ConcreteComponentWithProperty");
        }
    }

    public class DecoratedComponentWithProperty : IComponentWithProperty
    {
        private readonly IComponentWithProperty _component;
        public DecoratedComponentWithProperty(
            IComponentWithProperty component)
        {
            _component = component;
        }

        public string MyProperty
        {
            get
            {
                return _component.MyProperty + "AAA";
            }
            set 
            {
                var modifiedValue = value + "BBB";
                _component.MyProperty = modifiedValue;
            } 
        }

        public void Something()
        {
            Console.WriteLine("decoration code");
            _component.Something();
        }
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
