using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8ISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var oc = Factories.CreateOrderController();
            var gc = Factories.CreateGenericController<Order>();
        }
    }
}
