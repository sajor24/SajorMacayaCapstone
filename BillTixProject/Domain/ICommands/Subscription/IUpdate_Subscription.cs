using Domain.Models;

namespace Domain.ICommands
{
    public interface IUpdate_Subscription
    {
        Task ExecuteAsync(Subscription model);
    }
}
