using System.Threading.Tasks;

namespace ABCLearningPortal.DataAccess.Abstraction
{
    public interface IDataAccess
    {
        public Task<int> ExecuteAsync(IDataRequest request);

        public Task<TResponse> FetchAsync<TResponse>(IDataRequest<TResponse> request);

        public Task<TResponse> FetchListAsync<TResponse>(IDataRequest<TResponse> request);
    }
}
