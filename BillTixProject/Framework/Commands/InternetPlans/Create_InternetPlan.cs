using Domain.ICommands;
using Domain.Models;
using Framework.Extensions;

namespace Framework.Commands
{
    public class Create_InternetPlan : ICreate_InternetPlan
    {
        private readonly Repository _repository;
        public Create_InternetPlan(Repository repository) => _repository = repository;

        public async Task ExecuteAsync(InternetPlan model)
        {
            var param = model.ToCreateInternetPlanParameters();
            await _repository.SaveDataAsync("DefaultConnection", "[dbo].[CreateInternetPlan]", param);
        }
    }
}
