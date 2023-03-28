using ABCLearningPortal.DataAccess.Abstraction;
using System.Data;
using System.Data.SqlClient;

namespace ABCLearningPortal.DataAccess.Implementation
{
    internal class DbConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;
        public DbConnectionFactory(string connectionString) => _connectionString = connectionString;
        public IDbConnection NewConnection() => new SqlConnection(_connectionString);
    }
}