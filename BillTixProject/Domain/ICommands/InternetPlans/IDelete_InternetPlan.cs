using Domain.Models;

namespace Domain.ICommands
{
    public interface IDelete_InternetPlan
    {
        Task ExecuteAsync(InternetPlan model);
    }
}
