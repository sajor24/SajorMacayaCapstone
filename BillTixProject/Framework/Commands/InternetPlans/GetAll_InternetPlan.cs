using Domain.ICommands;
using Domain.Models;

namespace Framework.Commands
{
    public class GetAll_InternetPlan : IGetAll_InternetPlan
    {
        private readonly Repository _repository;
        public GetAll_InternetPlan(Repository repository) => _repository = repository;

        public async Task<IEnumerable<InternetPlan>?> ExecuteAsync()
        {
            return await _repository.GetDataAsync<InternetPlan>("DefaultConnection", "[dbo].[GetAllInternetPlans]", null);
        }
    }
}
