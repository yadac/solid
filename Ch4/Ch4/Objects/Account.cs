using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.Objects
{
    public class Account
    {
        public decimal Balance { get; private set; } = 0;

        public void AddTransaction(decimal v)
        {
            Balance += v;
        }
    }
}
