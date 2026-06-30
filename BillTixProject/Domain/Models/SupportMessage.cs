namespace Domain.Models
{
    public class SupportMessage
    {
        public string?   MessageId  { get; set; }
        public string?   UserId     { get; set; }
        public string?   SenderRole { get; set; }
        public string?   SentBy     { get; set; }
        public string?   Message    { get; set; }
        public DateTime  CreatedAt  { get; set; }

        // Joined from Users
        public string? FirstName { get; set; }
        public string? LastName  { get; set; }
        public string? Username  { get; set; }
    }
}
