namespace TicketBookingAPI.Model
{
    public class UserModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsLoggedIn { get; set; }
        public bool IsGuest { get; set; }
    }
}
