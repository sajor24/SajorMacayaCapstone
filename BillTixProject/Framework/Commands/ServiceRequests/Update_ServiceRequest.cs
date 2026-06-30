using Dapper;
using Domain.ICommands;
using Domain.Models;
using System.Data;

namespace Framework.Commands
{
    public class Update_ServiceRequest : IUpdate_ServiceRequest
    {
        private readonly Repository _repository;
        public Update_ServiceRequest(Repository repository) => _repository = repository;

        public async Task ExecuteAsync(ServiceRequest model)
        {
            var param = new DynamicParameters();
            param.Add("@RequestId",  model.RequestId,  DbType.String,   ParameterDirection.Input);
            param.Add("@Status",     model.Status,     DbType.String,   ParameterDirection.Input);
            param.Add("@AssignedTo", model.AssignedTo, DbType.String,   ParameterDirection.Input);
            param.Add("@ResolvedAt", model.ResolvedAt, DbType.DateTime, ParameterDirection.Input);
            await _repository.SaveDataAsync("DefaultConnection", "[dbo].[UpdateServiceRequest]", param);
        }
    }
}
