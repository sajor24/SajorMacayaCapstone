using Domain.Models;

namespace Domain.ICommands
{
    public interface ICreate_Notification
    {
        Task ExecuteAsync(Notification model);
    }
}
