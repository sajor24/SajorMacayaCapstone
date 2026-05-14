using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;
namespace Domain.ICommands
{
    public interface ICreate_User
    {
        public Task ExecuteAsync(Users user);
    }
}
