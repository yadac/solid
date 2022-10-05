using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDefinition.Objects
{
    public interface IStrategy
    {
        void Execute();
    }

    internal class ConcreteStrategyA : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("ConcreteStrategyA Execute");
        }
    }
    internal class ConcreteStrategyB : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("ConcreteStrategyB Execute");
        }
    }

    internal class Context
    {
        private readonly IStrategy _strategyA = new ConcreteStrategyA();
        private readonly IStrategy _strategyB = new ConcreteStrategyB();
        private IStrategy _currentStrategy;

        public Context()
        {
            _currentStrategy = _strategyA;
        }
        public void DoSomethins()
        {
            _currentStrategy.Execute();
            _currentStrategy = (_currentStrategy == _strategyA) ? _strategyB : _strategyA;
        }
    }
}
