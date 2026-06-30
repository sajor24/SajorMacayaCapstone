using Domain.Models;

namespace Domain.ICommands
{
    public interface IDelete_Notification
    {
        Task ExecuteAsync(Notification model);
    }
}
