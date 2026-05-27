using Domain.ICommands;
using Domain.Models;

namespace Framework.Commands
{
    public class GetAll_Subscription : IGetAll_Subscription
    {
        private readonly Repository _repository;
        public GetAll_Subscription(Repository repository) => _repository = repository;

        public async Task<IEnumerable<Subscription>?> ExecuteAsync()
        {
            return await _repository.GetDataAsync<Subscription>("DefaultConnection", "[dbo].[GetAllSubscription]", null);
        }
    }
}
