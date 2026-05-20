using Domain.Models;
namespace Domain.ICommands
{
    public interface IDelete_User
    {
        Task ExecuteAsync(Users model);

    }
}
