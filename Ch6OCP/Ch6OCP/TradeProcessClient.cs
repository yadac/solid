namespace Ch6OCP
{
    internal class TradeProcessClient
    {
        private readonly TradeProcessor _tradeProcessor;
        public TradeProcessClient(TradeProcessor tradeProcessor)
        {
            _tradeProcessor = tradeProcessor;
        }
        internal void DoProcess()
        {
            _tradeProcessor.TradeProcessTrades();
        }
    }
}
