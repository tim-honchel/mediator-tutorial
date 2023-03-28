namespace ABCLearningPortal.DataAccess.Abstraction
{
    public interface IDbConnectionFactory
    {
        public IDbConnectionFactory NewConnection();
    }
}
