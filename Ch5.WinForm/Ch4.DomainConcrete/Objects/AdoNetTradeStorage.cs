using Ch5.DomainIF.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ch5.DomainConcrete.Objects
{
    public class AdoNetTradeStorage : ITradeStorage
    {
        private readonly ILogger _logger;
        public AdoNetTradeStorage(
            ILogger logger)
        {
            _logger = logger;
        }
        public void Parsist(IEnumerable<TradeRecord> trades)
        {
            using (var connection = new System.Data.SqlClient.SqlConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    foreach (var trade in trades)
                    {
                        var command = connection.CreateCommand();
                        command.Transaction = transaction;
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.CommandText = "dbo.insert_trade";
                        command.Parameters.AddWithValue("@sourceCurrency", trade.SourceCurrency);
                        command.Parameters.AddWithValue("@destinationCurrency", trade.DestinationCurrency);
                        command.Parameters.AddWithValue("@lots", trade.Lots);
                        command.Parameters.AddWithValue("@price", trade.Price);
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
                connection.Close();
            }
            _logger.LogInfo("INFO: {0} trades processed", trades.Count());
        }
    }
}
