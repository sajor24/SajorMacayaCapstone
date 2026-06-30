using Domain.ICommands;
using Domain.Models;

namespace Framework.Commands
{
    public class GetAll_Notification : IGetAll_Notification
    {
        private readonly Repository _repository;
        public GetAll_Notification(Repository repository) => _repository = repository;

        public async Task<IEnumerable<Notification>?> ExecuteAsync()
        {
            return await _repository.GetDataAsync<Notification>("DefaultConnection", "[dbo].[GetAllNotifications]", null);
        }
    }
}
