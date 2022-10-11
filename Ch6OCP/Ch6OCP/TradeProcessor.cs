using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6OCP
{
    public class TradeProcessor
    {
        public virtual void ProcessTrades()
        {
            // retrieve
            Console.WriteLine("retrieve");
            // parse
            Console.WriteLine("parse");
            // store
            Console.WriteLine("store");
        }
    }

    public class TradeProcessor2 : TradeProcessor
    {
        public override void ProcessTrades()
        {
            // 拡張して新しい機能を実装
            Console.WriteLine("new process");
            base.ProcessTrades();
        }
    }
}
