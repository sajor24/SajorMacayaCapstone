using Domain.Models;
namespace Domain.ICommands
{
    public interface IGetAll_SupportMessage
    {
        Task<IEnumerable<SupportMessage>?> ExecuteAsync();
    }
}
