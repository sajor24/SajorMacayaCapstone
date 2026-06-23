using Domain.ICommands;
using Domain.Models;
using Framework.Extensions;

namespace Framework.Commands
{
    public class Create_UpgradeRequest : ICreate_UpgradeRequest
    {
        private readonly Repository _repository;
        public Create_UpgradeRequest(Repository repository) => _repository = repository;

        public async Task ExecuteAsync(UpgradeRequest model)
        {
            var param = model.ToCreateParameters();
            await _repository.SaveDataAsync("DefaultConnection", "[dbo].[CreateUpgradeRequest]", param);
        }
    }
}
