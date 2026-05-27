using Domain.ICommands;
using Domain.Models;

namespace Framework.Commands
{
    public class GetAll_Billing : IGetAll_Billing
    {
        private readonly Repository _repository;
        public GetAll_Billing(Repository repository) => _repository = repository;

        public async Task<IEnumerable<Billing>?> ExecuteAsync()
        {
            return await _repository.GetDataAsync<Billing>("DefaultConnection", "[dbo].[GetAllBilling]", null);
        }
    }
}
