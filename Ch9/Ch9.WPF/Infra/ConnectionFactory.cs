using Ch9.WPF.Domain;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Ch9.WPF.Infra
{
    public class ConnectionFactory : IConnectionFactory
    {
        public IDbConnection CreateConnection()
        {
            var settings =
                ConfigurationManager.ConnectionStrings["Ch9.WPF.Properties.Settings.Ch9ConnectionString"];
            var connection =
                new SqlConnection(settings.ConnectionString);
            return connection;
        }
    }

}
