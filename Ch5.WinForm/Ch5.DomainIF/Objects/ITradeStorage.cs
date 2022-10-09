using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ch5.DomainIF.Objects
{
    public interface ITradeStorage
    {
        void Parsist(IEnumerable<TradeRecord> trades);
    }
}
