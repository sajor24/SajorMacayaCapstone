using Domain.ICommands;
using Domain.Models;
using Framework.Extensions;

namespace Framework.Commands
{
    public class Update_Billing : IUpdate_Billing
    {
        private readonly Repository _repository;
        public Update_Billing(Repository repository) => _repository = repository;

        public async Task ExecuteAsync(Billing model)
        {
            var param = model.ToUpdateBillingParameters();
            await _repository.SaveDataAsync("DefaultConnection", "[dbo].[UpdateBilling]", param);
        }
    }
}
