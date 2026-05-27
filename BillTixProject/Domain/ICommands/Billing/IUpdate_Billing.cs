using Domain.Models;

namespace Domain.ICommands
{
    public interface IUpdate_Billing
    {
        Task ExecuteAsync(Billing model);
    }
}
