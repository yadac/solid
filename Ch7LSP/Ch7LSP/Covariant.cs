using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7LSP
{
    internal class Covariant
    {
    }

    public class Supertype : ICovariant<Supertype>
    {
        private object field1;
        private object field2;

        public void Method1() { }
        public void Method2() { }

        public Supertype MethodWhichReturnsT()
        {
            return this;
        }
    }
    public class Subtype : Supertype
    {
        private object field1;
        private object field2;
        private object field3;

        public void Method1() { }
        public void Method2() { }
        public void Method3() { }
    }

    public interface ICovariant<out T>
    {
        T MethodWhichReturnsT();
    }
}
