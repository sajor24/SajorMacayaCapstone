using Domain.Models;

namespace Domain.ICommands
{
    public interface IGetAll_UpgradeRequest
    {
        Task<IEnumerable<UpgradeRequest>?> ExecuteAsync();
    }
}
