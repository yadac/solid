using System.Data;

namespace Ch9.WPF.Domain
{
    public interface IConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
