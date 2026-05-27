using Domain.Models;

namespace Domain.ICommands
{
    public interface IGetByUser_Billing
    {
        Task<IEnumerable<Billing>?> ExecuteAsync(string userId);
    }
}
