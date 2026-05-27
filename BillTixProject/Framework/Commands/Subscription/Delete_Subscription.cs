using Domain.ICommands;
using Domain.Models;
using Framework.Extensions;

namespace Framework.Commands
{
    public class Delete_Subscription : IDelete_Subscription
    {
        private readonly Repository _repository;
        public Delete_Subscription(Repository repository) => _repository = repository;

        public async Task ExecuteAsync(Subscription model)
        {
            var param = model.ToDeleteSubscriptionParameters();
            await _repository.SaveDataAsync("DefaultConnection", "[dbo].[DeleteSubscription]", param);
        }
    }
}
