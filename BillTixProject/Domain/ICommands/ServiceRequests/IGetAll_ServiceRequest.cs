using Domain.Models;
namespace Domain.ICommands
{
    public interface IGetAll_ServiceRequest
    {
        Task<IEnumerable<ServiceRequest>?> ExecuteAsync();
    }
}
