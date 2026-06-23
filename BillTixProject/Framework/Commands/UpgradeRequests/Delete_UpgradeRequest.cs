using Domain.ICommands;
using Domain.Models;
using Dapper;
using System.Data;

namespace Framework.Commands
{
    public class Delete_UpgradeRequest : IDelete_UpgradeRequest
    {
        private readonly Repository _repository;
        public Delete_UpgradeRequest(Repository repository) => _repository = repository;

        public async Task ExecuteAsync(UpgradeRequest model)
        {
            var param = new DynamicParameters();
            param.Add("@RequestId", model.RequestId, DbType.String, ParameterDirection.Input);
            await _repository.SaveDataAsync("DefaultConnection", "[dbo].[DeleteUpgradeRequest]", param);
        }
    }
}
