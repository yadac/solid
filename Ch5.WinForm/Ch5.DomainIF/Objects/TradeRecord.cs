namespace Ch5.DomainIF.Objects
{
    public class TradeRecord
    {
        public string SourceCurrency { get; set; }
        public string DestinationCurrency { get; set; }
        public decimal Lots { get; set; }
        public decimal Price { get; set; }
    }
}
