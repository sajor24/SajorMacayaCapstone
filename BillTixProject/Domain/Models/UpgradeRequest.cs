namespace Domain.Models
{
    public class UpgradeRequest
    {
        public string? RequestId { get; set; }
        public string? UserId { get; set; }
        public string? PlanId { get; set; }
        public string? PlanName { get; set; }
        public string? ReferenceNo { get; set; }
        public string? Status { get; set; }
        public DateTime RequestedAt { get; set; }
        public DateTime? ProcessedAt { get; set; }

        // Joined from Users
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
    }

    public enum UpgradeRequestStatus
    {
        Pending,
        Approved,
        Rejected
    }
}
