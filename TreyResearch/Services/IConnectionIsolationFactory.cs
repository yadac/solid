using System.Data;

namespace TreyResearch.Services
{
    public interface IConnectionIsolationFactory
    {
        IDbConnection CreateConnection();
    }
}
