using Domain.Models;

namespace Domain.ICommands
{
    public interface ICreate_InternetPlan
    {
        Task ExecuteAsync(InternetPlan model);
    }
}
