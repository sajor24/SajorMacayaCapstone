using Dapper;
using Domain.ICommands;
using Domain.Models;
using System.Data;

namespace Framework.Commands
{
    public class GetByUser_SupportMessage : IGetByUser_SupportMessage
    {
        private readonly Repository _repository;
        public GetByUser_SupportMessage(Repository repository) => _repository = repository;

        public async Task<IEnumerable<SupportMessage>?> ExecuteAsync(string userId)
        {
            var param = new DynamicParameters();
            param.Add("@UserId", userId, DbType.String, ParameterDirection.Input);
            return await _repository.GetDataAsync<SupportMessage>("DefaultConnection", "[dbo].[GetSupportMessagesByUser]", param);
        }
    }
}
