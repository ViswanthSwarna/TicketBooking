namespace TicketBooking.Domain
{
    public class ActiveUser
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsLoggedIn { get; set; }
        public bool IsGuest { get; set; }
    }
}
