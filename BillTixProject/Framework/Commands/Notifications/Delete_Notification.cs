using Dapper;
using Domain.ICommands;
using Domain.Models;
using System.Data;

namespace Framework.Commands
{
    public class Delete_Notification : IDelete_Notification
    {
        private readonly Repository _repository;
        public Delete_Notification(Repository repository) => _repository = repository;

        public async Task ExecuteAsync(Notification model)
        {
            var param = new DynamicParameters();
            param.Add("@NotificationId", model.NotificationId, DbType.String, ParameterDirection.Input);
            await _repository.SaveDataAsync("DefaultConnection", "[dbo].[DeleteNotification]", param);
        }
    }
}
