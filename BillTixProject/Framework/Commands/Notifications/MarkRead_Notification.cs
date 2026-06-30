using Dapper;
using Domain.ICommands;
using Domain.Models;
using System.Data;

namespace Framework.Commands
{
    public class MarkRead_Notification : IMarkRead_Notification
    {
        private readonly Repository _repository;
        public MarkRead_Notification(Repository repository) => _repository = repository;

        public async Task ExecuteAsync(Notification model)
        {
            var param = new DynamicParameters();
            param.Add("@NotificationId", model.NotificationId, DbType.String, ParameterDirection.Input);
            await _repository.SaveDataAsync("DefaultConnection", "[dbo].[MarkNotificationRead]", param);
        }
    }
}
