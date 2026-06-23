using Domain.ICommands;
using Domain.Models;
using Framework.Extensions;

namespace Framework.Commands
{
    public class Delete_InternetPlan : IDelete_InternetPlan
    {
        private readonly Repository _repository;
        public Delete_InternetPlan(Repository repository) => _repository = repository;

        public async Task ExecuteAsync(InternetPlan model)
        {
            var param = model.ToDeleteInternetPlanParameters();
            await _repository.SaveDataAsync("DefaultConnection", "[dbo].[DeleteInternetPlan]", param);
        }
    }
}
