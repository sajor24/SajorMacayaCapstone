using Domain.Models;
using Domain.ICommands;
using Framework.Extensions;
namespace Framework.Commands
{
    public class Create_User : ICreate_User
    {
        private readonly Repository _repository;
        public Create_User(Repository repository)
        {
            _repository = repository;
        }
    
        public async Task ExecuteAsync(Users user)
        {
            var param = user.ToCreateUserDynamicParameters();
            await _repository.SaveDataAsync("DefaultConnection", "CreateUser", param);
        }
    }
}
