using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6OCP
{
    public abstract class TradeProcessorAbstract
    {
        public void ProcessTrades()
        {
            var tradeData = GetTradeData();
            var data = Parse(tradeData);
            Persist(data);
        }
        public abstract IEnumerable<string> GetTradeData();
        public abstract IEnumerable<string> Parse(IEnumerable<string> strings);
        public abstract void Persist(IEnumerable<string> data);

    }
    public class TradeProcessor : TradeProcessorAbstract
    {
        public override IEnumerable<string> GetTradeData()
        {
            List<string> strings = new List<string>();
            strings.Add("AAA");
            strings.Add("BBB");
            return strings;
        }

        public override IEnumerable<string> Parse(IEnumerable<string> strings)
        {
            var result = strings.Where(s => s.Contains("A"));
            //var result2 = from s in strings
            //              where s.Contains("B")
            //              select s;
            return result.ToList();            
        }

        public override void Persist(IEnumerable<string> data)
        {
            throw new NotImplementedException();
        }
    }

    public class TradeProcessor2 : TradeProcessor
    {
        // 拡張実装して差し替え
    }
}
