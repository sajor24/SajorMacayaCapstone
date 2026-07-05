namespace Domain.ICommands
{
    public interface IUpdateCompletedJobs_User
    {
        Task ExecuteAsync(string userId, int completedJobs);
    }
}
