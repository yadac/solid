using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5.DomainIF.Objects
{
    public interface ITradeDataProvider
    {
        IEnumerable<string> GetTradeData();
    }
}
