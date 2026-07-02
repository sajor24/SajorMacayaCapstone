namespace Domain.Models
{
    public class Subscription
    {
        public string? SubscriptionId { get; set; }
        public string? UserId { get; set; }
        public string? PlanName { get; set; }
        public decimal PlanPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Status { get; set; }
        public DateTime CreatedAt { get; set; }

        // Joined from Users
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }

    public enum PlanType
    {
        Basic,
        Standard,
        Premium
    }

    public enum SubscriptionStatus
    {
        Active,
        Inactive,
        Expired,
        Overdue
    }
}
