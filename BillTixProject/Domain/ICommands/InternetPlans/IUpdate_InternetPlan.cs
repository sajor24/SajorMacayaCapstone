using Domain.Models;

namespace Domain.ICommands
{
    public interface IUpdate_InternetPlan
    {
        Task ExecuteAsync(InternetPlan model);
    }
}
