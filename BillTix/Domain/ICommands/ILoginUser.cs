using Domain.Models;

namespace Domain.ICommands
{
    public interface ILoginUser
    {
        Task<Users?> LoginAsync(string username, string password);
    }
}