﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var shipping = new ShippingStrategy(decimal.MinusOne);
            //shipping.CalculateShippingCost(
            //    1, 1, null);

            var repository = new UserRepository();
            repository.GetByID(new Guid());
        }
    }
}
