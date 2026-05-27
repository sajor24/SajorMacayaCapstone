using Domain.Models;

namespace Domain.ICommands
{
    public interface IDelete_Subscription
    {
        Task ExecuteAsync(Subscription model);
    }
}
