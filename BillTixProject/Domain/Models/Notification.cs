namespace Domain.Models
{
    public class Notification
    {
        public string? NotificationId { get; set; }
        public string? UserId         { get; set; }
        public string? SentBy         { get; set; }
        public string? Title          { get; set; }
        public string? Message        { get; set; }
        public bool    IsRead         { get; set; }
        public DateTime CreatedAt     { get; set; }

        // Joined from Users
        public string? FirstName { get; set; }
        public string? LastName  { get; set; }
        public string? Username  { get; set; }
    }
}
