using BCrypt.Net;
using Domain.ICommands;
using Domain.Models;
using Framework.Extentions;

namespace Framework.Commands
{
    public class LoginUser : ILoginUser
    {
        private readonly Repository _repository;

        public LoginUser(Repository repository)
        {
            _repository = repository;
        }

        public async Task<Users?> LoginAsync(string username, string password)
        {
            var param = username.ToLoginParameters();

            var user = await _repository.GetSingleDataAsync<Users>(
                "DefaultConnection",
                "LoginUser",
                param
            );

            if (user == null)
                return null;

            bool isValid = BCrypt.Net.BCrypt.Verify(
                password,
                user.Password
            );

            return isValid ? user : null;
        }
    }
}