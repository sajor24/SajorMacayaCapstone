namespace Domain.Models
{
    public class Users
    {
        public string? UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public string? Email { get; set; }
        public string? ContactNumber { get; set; }
        public string? Address { get; set; }
        public string? Photo { get; set; }
        public DateTime CreatedAt { get; set; }

        // Technician-specific
        public string? TechSpecialization { get; set; }
        public string? TechArea           { get; set; }
        public int?    TechCompletedJobs  { get; set; }
    }

    public enum Role
    {
        Admin,
        Technician,
        Subscriber,
        Staff
    }
}
