using Ch5.DomainIF.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Ch5.DomainConcrete.Objects
{
    internal class SimpleTradeValidator : ITradeValidator
    {
        private readonly ILogger _logger;
        public SimpleTradeValidator(
            ILogger logger)
        {
            _logger = logger;
        }
        public bool Validate(int lineCount, string[] fields)
        {
            if (fields.Length != 3)
            {
                _logger.LogWarning("WARN: Line {0} malformed. Only {1} fields found.", lineCount, fields.Length.ToString());
                return false;
            }
            if (fields[0].Length != 6)
            {
                _logger.LogWarning("WARN: Trade currencies on line {0} malformed: '{1}'", lineCount, fields[0]);
                return false;
            }
            int tradeAmount;
            if (!int.TryParse(fields[1], out tradeAmount))
            {
                _logger.LogWarning("WARN: Trade amount on line {0} not a valid integer: '{1}'", lineCount, fields[1]);
                return false;
            }
            decimal tradePrice;
            if (!decimal.TryParse(fields[2], out tradePrice))
            {
                _logger.LogWarning("WARN: Trade price on line {0} not a valid decimal: '{1}'", lineCount, fields[2]);
                return false;
            }
            return true;
        }
    }
}
