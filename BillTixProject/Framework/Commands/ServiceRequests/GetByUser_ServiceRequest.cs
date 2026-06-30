using Dapper;
using Domain.ICommands;
using Domain.Models;
using System.Data;

namespace Framework.Commands
{
    public class GetByUser_ServiceRequest : IGetByUser_ServiceRequest
    {
        private readonly Repository _repository;
        public GetByUser_ServiceRequest(Repository repository) => _repository = repository;

        public async Task<IEnumerable<ServiceRequest>?> ExecuteAsync(string userId)
        {
            var param = new DynamicParameters();
            param.Add("@UserId", userId, DbType.String, ParameterDirection.Input);
            return await _repository.GetDataAsync<ServiceRequest>("DefaultConnection", "[dbo].[GetServiceRequestsByUser]", param);
        }
    }
}
