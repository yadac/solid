﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5.DomainIF.Objects
{
    public interface ITradeValidator
    {
        bool Validate(int lineCount, string[] strings);
    }
}
