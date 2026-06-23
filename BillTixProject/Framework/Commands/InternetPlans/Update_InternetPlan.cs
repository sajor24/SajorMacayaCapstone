using Domain.ICommands;
using Domain.Models;
using Framework.Extensions;

namespace Framework.Commands
{
    public class Update_InternetPlan : IUpdate_InternetPlan
    {
        private readonly Repository _repository;
        public Update_InternetPlan(Repository repository) => _repository = repository;

        public async Task ExecuteAsync(InternetPlan model)
        {
            var param = model.ToUpdateInternetPlanParameters();
            await _repository.SaveDataAsync("DefaultConnection", "[dbo].[UpdateInternetPlan]", param);
        }
    }
}
