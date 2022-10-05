using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDefinition.Objects
{
    public interface IFluentIF
    {
        IFluentIF Method1();
        IFluentIF Method2();

    }
    internal class FluentClient : IFluentIF
    {
        public IFluentIF Method1()
        {
            Console.WriteLine("invoke Method1");
            return this;
        }

        public IFluentIF Method2()
        {
            Console.WriteLine("invoke Method2");
            return this;
        }
    }
}
