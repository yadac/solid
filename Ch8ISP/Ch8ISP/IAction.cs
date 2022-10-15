using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8ISP
{
    public interface IAction
    {
        void Act();
    }

    public interface IFunctions<T>
    {
        T Do();
    }

    public interface IPredicate
    {
        bool Test();
    }

    public class ActionSample<T> : IAction, IFunctions<T>, IPredicate
    {
        public void Act()
        {
            Console.WriteLine("act");
        }

        public T Do()
        {
            Console.WriteLine("do");
            return default(T);
        }

        public bool Test()
        {
            return true;
        }
    }
}
