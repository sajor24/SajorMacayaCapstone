using Domain.Models;

namespace Domain.ICommands
{
    public interface IGetByUser_Subscription
    {
        Task<IEnumerable<Subscription>?> ExecuteAsync(string userId);
    }
}
