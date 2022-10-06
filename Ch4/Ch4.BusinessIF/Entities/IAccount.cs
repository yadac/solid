using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.DomainIF.Entities
{
    public interface IAccount
    {
        void AddTransaction(decimal amount);
    }
}
