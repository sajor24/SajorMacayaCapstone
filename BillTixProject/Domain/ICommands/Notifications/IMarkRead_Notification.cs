using Domain.Models;

namespace Domain.ICommands
{
    public interface IMarkRead_Notification
    {
        Task ExecuteAsync(Notification model);
    }
}
