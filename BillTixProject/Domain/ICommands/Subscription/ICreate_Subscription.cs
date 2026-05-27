using Domain.Models;

namespace Domain.ICommands
{
    public interface ICreate_Subscription
    {
        Task ExecuteAsync(Subscription model);
    }
}
