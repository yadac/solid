using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3Composite
{
    public class DateTester
    {
        public bool IsEventDate 
        { 
            get { return DateTime.Now.Day % 2 == 0; } 
        }
    }

    public class IsEventDate : IPredicate
    {
        private readonly DateTester _datetester;
        public IsEventDate(DateTester dateTester)
        {
            _datetester = dateTester;
        }
        public bool Test()
        {
            return _datetester.IsEventDate;
        }
    }

    public interface IPredicate
    {
        bool Test();
    }

    public class ConcreteComponent : IComponent
    {
        public void Something()
        {
            Console.WriteLine("concrete do something");
        }
    }

    public class PredicatedComponent : IComponent
    {
        private readonly IComponent _component;
        private readonly IPredicate _predicate;

        public PredicatedComponent(
            IComponent component,
            IPredicate predicate)
        {
            _component = component;
            _predicate = predicate;
        }

        public void Something()
        {
            if (_predicate.Test())
            {
                _component.Something();
            }
        }
    }

    public class PredicatedDecoratorExample
    {
        private readonly IComponent _component;
        public PredicatedDecoratorExample(IComponent component)
        {
            _component = component;
        }
        public void Run()
        {
            _component.Something();
        }
    }
}
