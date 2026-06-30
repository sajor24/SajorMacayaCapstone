using Dapper;
using Domain.ICommands;
using Domain.Models;
using System.Data;

namespace Framework.Commands
{
    public class Create_SupportMessage : ICreate_SupportMessage
    {
        private readonly Repository _repository;
        public Create_SupportMessage(Repository repository) => _repository = repository;

        public async Task ExecuteAsync(SupportMessage model)
        {
            var param = new DynamicParameters();
            param.Add("@UserId",     model.UserId,     DbType.String, ParameterDirection.Input);
            param.Add("@SenderRole", model.SenderRole, DbType.String, ParameterDirection.Input);
            param.Add("@SentBy",     model.SentBy,     DbType.String, ParameterDirection.Input);
            param.Add("@Message",    model.Message,    DbType.String, ParameterDirection.Input);
            await _repository.SaveDataAsync("DefaultConnection", "[dbo].[CreateSupportMessage]", param);
        }
    }
}
