using ABCLearningPortal.DataAccess.Abstraction;

namespace ABCLearningPortal.DataAccess.Implementation
{
    public static class DataAccessFactory
    {
        public static IDataAccess NewDataAccess(string connectionString) => new DataAccess(new DbConnectionFactory(connectionString));

    }
}
