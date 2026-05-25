using Domain.ICommands;
using Domain.Models;
using Framework.Extensions;

namespace Framework.Commands
{
    public class GetRecent_Billing : IGetRecent_Billing
    {
        private readonly Repository _repository;
        public GetRecent_Billing(Repository repository) => _repository = repository;

        public async Task<IEnumerable<Billing>?> ExecuteAsync(int top = 5)
        {
            var param = BillingExtension.ToGetRecentBillingParameters(top);
            return await _repository.GetDataAsync<Billing>("DefaultConnection", "[dbo].[GetRecentBilling]", param);
        }
    }
}
