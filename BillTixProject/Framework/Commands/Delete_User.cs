using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;
using Domain.ICommands;
using Framework.Extensions;
namespace Framework.Commands
{
    public class Delete_User : IDelete_User
    {
        private readonly Repository _repository;

        public Delete_User(Repository repository)
        {
            _repository = repository;
        }

        public async Task ExecuteAsync(Users model)
        {
            var parameters = model.ToDeleteUserDynamicParameters();
            await _repository.SaveDataAsync("DefaultConnection", "[dbo].[DeleteUser]", parameters);
        }
    }
}
