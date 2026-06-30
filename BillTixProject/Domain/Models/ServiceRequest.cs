namespace Domain.Models
{
    public class ServiceRequest
    {
        public string?   RequestId     { get; set; }
        public string?   UserId        { get; set; }
        public string?   IssueType     { get; set; }
        public string?   Priority      { get; set; }
        public string?   Description   { get; set; }
        public string?   ContactNumber { get; set; }
        public string?   Status        { get; set; }
        public string?   AssignedTo    { get; set; }
        public DateTime? ResolvedAt    { get; set; }
        public DateTime  CreatedAt     { get; set; }

        // Joined
        public string? FirstName { get; set; }
        public string? LastName  { get; set; }
        public string? Username  { get; set; }
    }
}
