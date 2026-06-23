using Domain.Models;

namespace Domain.ICommands
{
    public interface IDelete_UpgradeRequest
    {
        Task ExecuteAsync(UpgradeRequest model);
    }
}
