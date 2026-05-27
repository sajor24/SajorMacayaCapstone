using Domain.Models;

namespace Domain.ICommands
{
    public interface IGetAll_Subscription
    {
        Task<IEnumerable<Subscription>?> ExecuteAsync();
    }
}
