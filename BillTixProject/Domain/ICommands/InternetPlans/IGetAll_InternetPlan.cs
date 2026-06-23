using Domain.Models;

namespace Domain.ICommands
{
    public interface IGetAll_InternetPlan
    {
        Task<IEnumerable<InternetPlan>?> ExecuteAsync();
    }
}
