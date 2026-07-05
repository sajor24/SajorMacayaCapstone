using Dapper;
using Domain.ICommands;
using Domain.Models;
using System.Data;

namespace Framework.Commands
{
    public class Delete_ServiceRequest : IDelete_ServiceRequest
    {
        private readonly Repository _repository;
        public Delete_ServiceRequest(Repository repository) => _repository = repository;

        public async Task ExecuteAsync(ServiceRequest model)
        {
            var param = new DynamicParameters();
            param.Add("@RequestId", model.RequestId, DbType.String, ParameterDirection.Input);
            await _repository.SaveDataAsync("DefaultConnection", "[dbo].[DeleteServiceRequest]", param);
        }
    }
}