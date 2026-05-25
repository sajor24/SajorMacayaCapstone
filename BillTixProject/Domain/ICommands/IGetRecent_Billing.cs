using Domain.Models;

namespace Domain.ICommands
{
    public interface IGetRecent_Billing
    {
        Task<IEnumerable<Billing>?> ExecuteAsync(int top = 5);
    }
}
