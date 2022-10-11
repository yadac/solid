using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TradeProcessClient tradeProcessClient = 
                new TradeProcessClient(new TradeProcessor());
            tradeProcessClient.DoProcess();
        }
    }
}
