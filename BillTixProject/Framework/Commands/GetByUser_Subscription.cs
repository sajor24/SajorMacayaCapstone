using Domain.ICommands;
using Domain.Models;
using Framework.Extensions;

namespace Framework.Commands
{
    public class GetByUser_Subscription : IGetByUser_Subscription
    {
        private readonly Repository _repository;
        public GetByUser_Subscription(Repository repository) => _repository = repository;

        public async Task<IEnumerable<Subscription>?> ExecuteAsync(string userId)
        {
            var param = SubscriptionExtension.ToGetByUserSubscriptionParameters(userId);
            return await _repository.GetDataAsync<Subscription>("DefaultConnection", "[dbo].[GetSubscriptionByUser]", param);
        }
    }
}
