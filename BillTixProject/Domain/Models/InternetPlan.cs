namespace Domain.Models
{
    public class InternetPlan
    {
        public string? PlanId { get; set; }
        public string? PlanName { get; set; }
        public string? Speed { get; set; }
        public decimal Price { get; set; }
        public string? Features { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        public List<string> FeatureList =>
            string.IsNullOrEmpty(Features)
            ? new()
            : Features.Split(',').Select(f => f.Trim()).ToList();
    }
}
