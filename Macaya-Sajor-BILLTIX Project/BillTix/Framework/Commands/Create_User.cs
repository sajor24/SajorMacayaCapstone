using Domain.Models;
using Domain.ICommands;
using Framework.Extentions;
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
            var param = user.ToCreateEmployeeDynamicParameters();
            await _repository.SaveDataAsync("DefaultConnection","CreateUsers",  param);

        }

    }
}
