using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDefinition.Objects
{
    internal class Swan
    {
        public void Walk()
        {
            Console.WriteLine("swan is walking");
        }
        public void Swim()
        {
            Console.WriteLine("swan is swimming");
        }
        public void Quack()
        {
            Console.WriteLine("swan is quacking");
        }
    }

    public interface IDuck
    {
        void Walk();
        void Swim();
        void Quack();
    }

    internal class Duck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("duck is quacking");
        }

        public void Swim()
        {
            Console.WriteLine("duck is swimming");
        }

        public void Walk()
        {
            Console.WriteLine("duck is walking");
        }
    }
}
