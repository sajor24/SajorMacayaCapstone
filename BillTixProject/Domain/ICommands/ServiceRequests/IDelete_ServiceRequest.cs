using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ICommands
{
    public interface IDelete_ServiceRequest
    {
        Task ExecuteAsync(ServiceRequest model);

    }
}
