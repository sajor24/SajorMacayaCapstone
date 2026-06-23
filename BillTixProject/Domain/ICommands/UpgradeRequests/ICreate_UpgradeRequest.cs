using Domain.Models;

namespace Domain.ICommands
{
    public interface ICreate_UpgradeRequest
    {
        Task ExecuteAsync(UpgradeRequest model);
    }
}
