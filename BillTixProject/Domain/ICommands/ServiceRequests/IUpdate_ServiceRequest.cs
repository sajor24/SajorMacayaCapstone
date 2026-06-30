using Domain.Models;
namespace Domain.ICommands
{
    public interface IUpdate_ServiceRequest
    {
        Task ExecuteAsync(ServiceRequest model);
    }
}
