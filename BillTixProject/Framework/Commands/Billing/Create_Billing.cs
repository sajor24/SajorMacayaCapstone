using Domain.ICommands;
using Domain.Models;
using Framework.Extensions;

namespace Framework.Commands
{
    public class Create_Billing : ICreate_Billing
    {
        private readonly Repository _repository;
        public Create_Billing(Repository repository) => _repository = repository;

        public async Task ExecuteAsync(Billing model)
        {
            var param = model.ToCreateBillingParameters();
            await _repository.SaveDataAsync("DefaultConnection", "[dbo].[CreateBilling]", param);
        }
    }
}
