using System.Data;

namespace ABCLearningPortal.DataAccess.Abstraction
{
    public interface IDbConnectionFactory
    {
        public IDbConnection NewConnection();
    }
}
