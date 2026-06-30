using Domain.Models;
namespace Domain.ICommands
{
    public interface ICreate_ServiceRequest
    {
        Task ExecuteAsync(ServiceRequest model);
    }
}
