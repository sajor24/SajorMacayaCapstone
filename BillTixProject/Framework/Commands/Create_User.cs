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
            // Hash password before saving
            if (!string.IsNullOrWhiteSpace(user.Password))
                user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);

            var param = user.ToCreateUserDynamicParameters();
            await _repository.SaveDataAsync("DefaultConnection", "CreateUser", param);
        }
    }
}
