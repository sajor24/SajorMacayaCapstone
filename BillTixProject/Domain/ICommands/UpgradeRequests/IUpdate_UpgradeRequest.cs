using Domain.Models;

namespace Domain.ICommands
{
    public interface IUpdate_UpgradeRequest
    {
        Task ExecuteAsync(UpgradeRequest model);
    }
}
