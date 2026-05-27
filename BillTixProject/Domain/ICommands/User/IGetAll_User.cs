using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;
namespace Domain.ICommands
{
    public interface IGetAll_User
    {
        Task<IEnumerable<Users>?> ExecuteAsync();

    }
}
