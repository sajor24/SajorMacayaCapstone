using Domain.Models;

namespace Domain.ICommands
{
    public interface IGetAll_Billing
    {
        Task<IEnumerable<Billing>?> ExecuteAsync();
    }
}
