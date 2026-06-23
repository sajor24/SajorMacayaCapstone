using Domain.ICommands;
using Domain.Models;

namespace Framework.Commands
{
    public class GetAll_UpgradeRequest : IGetAll_UpgradeRequest
    {
        private readonly Repository _repository;
        public GetAll_UpgradeRequest(Repository repository) => _repository = repository;

        public async Task<IEnumerable<UpgradeRequest>?> ExecuteAsync()
        {
            return await _repository.GetDataAsync<UpgradeRequest>("DefaultConnection", "[dbo].[GetAllUpgradeRequests]", null);
        }
    }
}
