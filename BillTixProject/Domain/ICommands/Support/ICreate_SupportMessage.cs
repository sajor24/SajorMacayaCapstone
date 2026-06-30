using Domain.Models;
namespace Domain.ICommands
{
    public interface ICreate_SupportMessage
    {
        Task ExecuteAsync(SupportMessage model);
    }
}
