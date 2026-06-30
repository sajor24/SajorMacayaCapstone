using Domain.ICommands;
using Domain.Models;

namespace Framework.Commands
{
    public class GetAll_SupportMessage : IGetAll_SupportMessage
    {
        private readonly Repository _repository;
        public GetAll_SupportMessage(Repository repository) => _repository = repository;

        public async Task<IEnumerable<SupportMessage>?> ExecuteAsync()
        {
            return await _repository.GetDataAsync<SupportMessage>("DefaultConnection", "[dbo].[GetAllSupportMessages]", null);
        }
    }
}
