namespace Domain.ICommands
{
    public interface IEmailService
    {
        Task SendAsync(string toEmail, string subject, string body);
        Task SendBillingDueReminderAsync(string toEmail, string firstName, string billingId, decimal amount, DateTime dueDate);
        Task SendMaintenanceNoticeAsync(string toEmail, string firstName, string title, string message);
    }
}
