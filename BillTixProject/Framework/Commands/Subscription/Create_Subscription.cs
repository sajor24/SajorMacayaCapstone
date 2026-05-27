using Domain.ICommands;
using Domain.Models;
using Framework.Extensions;

namespace Framework.Commands
{
    public class Create_Subscription : ICreate_Subscription
    {
        private readonly Repository _repository;
        public Create_Subscription(Repository repository) => _repository = repository;

        public async Task ExecuteAsync(Subscription model)
        {
            var param = model.ToCreateSubscriptionParameters();
            await _repository.SaveDataAsync("DefaultConnection", "[dbo].[CreateSubscription]", param);
        }
    }
}
