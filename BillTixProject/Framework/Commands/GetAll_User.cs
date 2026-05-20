using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;
using Domain.ICommands;
namespace Framework.Commands
{
    public class GetAll_User : IGetAll_User
    {
        private readonly Repository _repository;

        public GetAll_User(Repository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Users>?> ExecuteAsync()
        {
            return await _repository.GetDataAsync<Users>("DefaultConnection", "[dbo].[GetAllUser]", null);
        }
    }
}
