using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDefinition.Objects
{
    public interface ITargetInterface
    {
        void DoSomething();
    }

    public class ConcreteTargetInterface : ITargetInterface
    {
        public void DoSomething()
        {
            Console.WriteLine("ConcreteTargetInterface");
        }
    }

    public static class MixInExtentions
    {
        public static int FirstExtensionMethod(
            this ITargetInterface target,
            int extraParam)
        {
            return extraParam++;
        }
    }
}
