using Domain.ICommands;
using Domain.Models;

namespace Framework.Commands
{
    public class GetAll_ServiceRequest : IGetAll_ServiceRequest
    {
        private readonly Repository _repository;
        public GetAll_ServiceRequest(Repository repository) => _repository = repository;

        public async Task<IEnumerable<ServiceRequest>?> ExecuteAsync()
        {
            return await _repository.GetDataAsync<ServiceRequest>("DefaultConnection", "[dbo].[GetAllServiceRequests]", null);
        }
    }
}
