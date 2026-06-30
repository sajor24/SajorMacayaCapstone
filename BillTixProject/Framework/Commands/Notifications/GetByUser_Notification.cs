using Dapper;
using Domain.ICommands;
using Domain.Models;
using System.Data;

namespace Framework.Commands
{
    public class GetByUser_Notification : IGetByUser_Notification
    {
        private readonly Repository _repository;
        public GetByUser_Notification(Repository repository) => _repository = repository;

        public async Task<IEnumerable<Notification>?> ExecuteAsync(string userId)
        {
            var param = new DynamicParameters();
            param.Add("@UserId", userId, DbType.String, ParameterDirection.Input);
            return await _repository.GetDataAsync<Notification>("DefaultConnection", "[dbo].[GetNotificationsByUser]", param);
        }
    }
}
