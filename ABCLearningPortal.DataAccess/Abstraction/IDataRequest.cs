namespace ABCLearningPortal.DataAccess.Abstraction
{
    public interface IDataRequest
    {
        public object? GetParameters();

        public string GetSql();
    }

    public interface IDataRequest<TResponse> : IDataRequest
    {

    }
}
