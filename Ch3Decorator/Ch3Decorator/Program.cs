using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3Decorator
{
    internal class Program
    {
        static IComponent component;
        static void Main(string[] args)
        {
            component = new DecoratorComponent(new ConcreteComponent());
            component.Something();
        }
    }
}
