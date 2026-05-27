using Domain.ICommands;
using Domain.Models;
using Framework.Extensions;

namespace Framework.Commands
{
    public class Update_Subscription : IUpdate_Subscription
    {
        private readonly Repository _repository;
        public Update_Subscription(Repository repository) => _repository = repository;

        public async Task ExecuteAsync(Subscription model)
        {
            var param = model.ToUpdateSubscriptionParameters();
            await _repository.SaveDataAsync("DefaultConnection", "[dbo].[UpdateSubscription]", param);
        }
    }
}
