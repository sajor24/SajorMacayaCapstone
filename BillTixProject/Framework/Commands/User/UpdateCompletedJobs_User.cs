using Dapper;
using Domain.ICommands;
using System.Data;

namespace Framework.Commands
{
    public class UpdateCompletedJobs_User : IUpdateCompletedJobs_User
    {
        private readonly Repository _repository;

        public UpdateCompletedJobs_User(Repository repository) => _repository = repository;

        public async Task ExecuteAsync(string userId, int completedJobs)
        {
            var param = new DynamicParameters();
            param.Add("@UserId",            userId,        DbType.String, ParameterDirection.Input);
            param.Add("@TechCompletedJobs", completedJobs, DbType.Int32,  ParameterDirection.Input);
            await _repository.SaveDataAsync("DefaultConnection", "[dbo].[UpdateTechCompletedJobs]", param);
        }
    }
}
