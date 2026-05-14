namespace Domain.Models
{
    public class Users
    {
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }

        public string? Role { get; set; }
    }

    public enum Role
    {
        Admin,
        Technician,
        Subscriber,
        Staff
    }
}