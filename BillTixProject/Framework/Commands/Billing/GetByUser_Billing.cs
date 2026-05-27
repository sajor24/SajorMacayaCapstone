using Domain.ICommands;
using Domain.Models;
using Framework.Extensions;

namespace Framework.Commands
{
    public class GetByUser_Billing : IGetByUser_Billing
    {
        private readonly Repository _repository;
        public GetByUser_Billing(Repository repository) => _repository = repository;

        public async Task<IEnumerable<Billing>?> ExecuteAsync(string userId)
        {
            var param = BillingExtension.ToGetByUserBillingParameters(userId);
            return await _repository.GetDataAsync<Billing>("DefaultConnection", "[dbo].[GetBillingByUser]", param);
        }
    }
}
