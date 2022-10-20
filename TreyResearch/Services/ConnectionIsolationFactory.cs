using System.Data;
using System.Data.SqlClient;

namespace TreyResearch.Services
{
    public class ConnectionIsolationFactory : IConnectionIsolationFactory
    {
        public IDbConnection CreateConnection()
        {
            //var settings =
            //    ConfigurationManager.ConnectionStrings["Ch9.WPF.Properties.Settings.Ch9ConnectionString"];
            var connection =
                new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            return connection;
        }
    }
}
