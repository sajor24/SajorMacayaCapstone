using Domain.Models;
namespace Domain.ICommands
{
    public interface IGetByUser_ServiceRequest
    {
        Task<IEnumerable<ServiceRequest>?> ExecuteAsync(string userId);
    }
}
