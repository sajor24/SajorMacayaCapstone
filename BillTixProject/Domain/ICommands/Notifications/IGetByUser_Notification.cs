using Domain.Models;

namespace Domain.ICommands
{
    public interface IGetByUser_Notification
    {
        Task<IEnumerable<Notification>?> ExecuteAsync(string userId);
    }
}
