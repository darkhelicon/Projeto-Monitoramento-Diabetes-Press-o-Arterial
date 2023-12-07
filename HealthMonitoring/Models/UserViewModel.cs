namespace HealthMonitoring.Models
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public int PersonId { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool hasH { get; set; }
        public bool hasG { get; set; }
        public DateTime Date { get; set; }
    }
}
