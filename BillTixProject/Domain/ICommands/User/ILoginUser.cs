using Domain.Models;

namespace Domain.ICommands
{
    public interface ILoginUser
    {
        Task<Users?> ExecuteAsync(string user , string password);

    }
}
