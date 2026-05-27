using Dapper;
using Domain.ICommands;
using Domain.Models;

namespace Framework.Commands
{
    public class LoginUser : ILoginUser
    {
        private readonly Repository _repository;

        public LoginUser(Repository repository)
        {
            _repository = repository;
        }

        public async Task<Users?> ExecuteAsync(string username, string password)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Username", username);
            parameters.Add("@Password", password);

            return await _repository.GetSingleDataAsync<Users>(
                "DefaultConnection",
                "[dbo].[LoginUser]",
                parameters
            );
        }
    }
}
