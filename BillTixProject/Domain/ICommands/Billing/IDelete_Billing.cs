using Domain.Models;

namespace Domain.ICommands
{
    public interface IDelete_Billing
    {
        Task ExecuteAsync(Billing model);
    }
}
