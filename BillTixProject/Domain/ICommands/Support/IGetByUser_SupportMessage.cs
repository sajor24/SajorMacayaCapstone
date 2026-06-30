using Domain.Models;
namespace Domain.ICommands
{
    public interface IGetByUser_SupportMessage
    {
        Task<IEnumerable<SupportMessage>?> ExecuteAsync(string userId);
    }
}
