using Ch5.DomainIF.Objects;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Ch5.DomainConcrete.Objects
{
    public class SQLiteTradeStorage : ITradeStorage
    {
        private readonly ILogger _logger;
        public SQLiteTradeStorage(
            ILogger logger)
        {
            _logger = logger;
        }
        public void Parsist(IEnumerable<TradeRecord> trades)
        {
            // todo: change to insert
            using (SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\temp\solid.db;Version=3;"))
            {
                con.Open();
                try
                {
                    string sql = "create table products (id int, code varchar(8), name varchar(20), price int)";
                    SQLiteCommand com = new SQLiteCommand(sql, con);
                    com.ExecuteNonQuery();
                }
                finally
                {
                    con.Close();
                }

            }
        }
    }
}
