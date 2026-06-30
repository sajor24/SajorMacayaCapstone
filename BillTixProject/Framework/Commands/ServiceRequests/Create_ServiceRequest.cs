using Dapper;
using Domain.ICommands;
using Domain.Models;
using System.Data;

namespace Framework.Commands
{
    public class Create_ServiceRequest : ICreate_ServiceRequest
    {
        private readonly Repository _repository;
        public Create_ServiceRequest(Repository repository) => _repository = repository;

        public async Task ExecuteAsync(ServiceRequest model)
        {
            var param = new DynamicParameters();
            param.Add("@UserId",        model.UserId,        DbType.String, ParameterDirection.Input);
            param.Add("@IssueType",     model.IssueType,     DbType.String, ParameterDirection.Input);
            param.Add("@Priority",      model.Priority,      DbType.String, ParameterDirection.Input);
            param.Add("@Description",   model.Description,   DbType.String, ParameterDirection.Input);
            param.Add("@ContactNumber", model.ContactNumber, DbType.String, ParameterDirection.Input);
            await _repository.SaveDataAsync("DefaultConnection", "[dbo].[CreateServiceRequest]", param);
        }
    }
}
