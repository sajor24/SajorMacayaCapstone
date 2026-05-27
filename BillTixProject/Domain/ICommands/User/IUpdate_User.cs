using Domain.Models;

namespace Domain.ICommands
{
    public interface IUpdate_User
    {
        Task ExecuteAsync(Users model);
    }
}
