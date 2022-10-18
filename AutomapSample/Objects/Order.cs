using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomapSample.Objects
{
    internal class Order
    {
        public string Name { get; set; } = "";
        public DateTime OrderDate { get; set; }
        public int AmountPrice { get; set; }
    }

    internal class OrderDto
    {
        public string Name { get; set; } = "";
        public DateTime OrderDate { get; set; }
        public int Amount { get; set; }
    }
}
