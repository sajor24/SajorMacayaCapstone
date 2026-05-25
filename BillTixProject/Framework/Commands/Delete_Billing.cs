using Domain.ICommands;
using Domain.Models;
using Framework.Extensions;

namespace Framework.Commands
{
    public class Delete_Billing : IDelete_Billing
    {
        private readonly Repository _repository;
        public Delete_Billing(Repository repository) => _repository = repository;

        public async Task ExecuteAsync(Billing model)
        {
            var param = model.ToDeleteBillingParameters();
            await _repository.SaveDataAsync("DefaultConnection", "[dbo].[DeleteBilling]", param);
        }
    }
}
