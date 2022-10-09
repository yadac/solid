using Ch5.DomainIF.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5.WinForm.Objects
{
    /// <summary>
    /// 取引データを別のフォーマットに変換するプロセス
    /// </summary>
    public class TradeProcessor
    {
        private readonly ITradeDataProvider _tradeDataProvider;
        private readonly ITradeParser _tradeParser;
        private readonly ITradeStorage _tradeStorage;

        public TradeProcessor(
            ITradeDataProvider tradeDataProvider,
            ITradeParser tradeParser,
            ITradeStorage tradeStorage)
        {
            _tradeDataProvider = tradeDataProvider;
            _tradeParser = tradeParser;
            _tradeStorage = tradeStorage;
        }

        public void ProcessTrades()
        {
            var lines = _tradeDataProvider.GetTradeData();
            var trades = _tradeParser.Parse(lines);
            _tradeStorage.Parsist(trades);
        }
    }
}
