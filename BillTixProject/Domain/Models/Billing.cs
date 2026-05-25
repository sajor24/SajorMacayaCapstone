namespace Domain.Models
{
    public class Billing
    {
        public string? BillingId { get; set; }
        public string? UserId { get; set; }
        public decimal Amount { get; set; }
        public string? PaymentMethod { get; set; }
        public string? Status { get; set; }
        public DateTime BillingDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? PaidAt { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }

        // Joined from Users
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
