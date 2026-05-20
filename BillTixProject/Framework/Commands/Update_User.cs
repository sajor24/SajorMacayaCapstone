using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;
using Domain.ICommands;
using Framework.Extensions;
namespace Framework.Commands
{
    public class Update_User : IUpdate_User
    {
        private readonly Repository _repository;

        public Update_User(Repository repository)
        {
            _repository = repository;
        }

        public async Task ExecuteAsync(Users model)
        {
            var parameters = model.ToUserDynamicParameters();
            await _repository.SaveDataAsync("DefaultConnection", "[dbo].[UpdateUser]", parameters);
        }
    }
}
