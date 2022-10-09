using Ch5.DomainIF.Objects;
using System;
using System.Collections.Generic;

namespace Ch5.DomainConcrete.Objects
{
    public class SimpleTradeParser : ITradeParser
    {
        private readonly ITradeValidator _validator;
        private readonly ITradeMapper _tradeMapper;
        public SimpleTradeParser(
            ITradeValidator tradeValidator,
            ITradeMapper tradeMapper)
        {
            _validator = tradeValidator;
            _tradeMapper = tradeMapper;
        }

        public IEnumerable<TradeRecord> Parse(IEnumerable<string> lines)
        {
            var trades = new List<TradeRecord>();

            var lineCount = 1;
            foreach (var line in lines)
            {
                var fields = line.Split(new char[] { ',' });

                if (!_validator.Validate(lineCount, fields))
                {
                    continue;
                }
                var trade = _tradeMapper.Map(fields);
                trades.Add(trade);
                lineCount++;
            }
            return trades;
        }
    }
}
