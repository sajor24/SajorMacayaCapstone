using Domain.ICommands;
using Domain.Models;
using Framework.Extensions;

namespace Framework.Commands
{
    public class Update_UpgradeRequest : IUpdate_UpgradeRequest
    {
        private readonly Repository _repository;
        public Update_UpgradeRequest(Repository repository) => _repository = repository;

        public async Task ExecuteAsync(UpgradeRequest model)
        {
            var param = model.ToUpdateParameters();
            await _repository.SaveDataAsync("DefaultConnection", "[dbo].[UpdateUpgradeRequest]", param);
        }
    }
}
