using Dapper;
using Domain.ICommands;
using Domain.Models;
using System.Data;

namespace Framework.Commands
{
    public class Create_Notification : ICreate_Notification
    {
        private readonly Repository _repository;
        public Create_Notification(Repository repository) => _repository = repository;

        public async Task ExecuteAsync(Notification model)
        {
            var param = new DynamicParameters();
            param.Add("@UserId",  model.UserId,  DbType.String, ParameterDirection.Input);
            param.Add("@SentBy",  model.SentBy,  DbType.String, ParameterDirection.Input);
            param.Add("@Title",   model.Title,   DbType.String, ParameterDirection.Input);
            param.Add("@Message", model.Message, DbType.String, ParameterDirection.Input);
            await _repository.SaveDataAsync("DefaultConnection", "[dbo].[CreateNotification]", param);
        }
    }
}
