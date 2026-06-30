using Domain.Models;

namespace Domain.ICommands
{
    public interface IGetAll_Notification
    {
        Task<IEnumerable<Notification>?> ExecuteAsync();
    }
}
