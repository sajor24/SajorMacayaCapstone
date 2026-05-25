using Domain.Models;

namespace Domain.ICommands
{
    public interface ICreate_Billing
    {
        Task ExecuteAsync(Billing model);
    }
}
