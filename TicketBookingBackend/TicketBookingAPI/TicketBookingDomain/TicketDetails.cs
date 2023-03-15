namespace TicketBookingDomain
{
    public class TicketDetails
    {
        public int Id { get; set; }
        public BusDetails BusDetails { get; set; }
        public int BusId { get; set; }
        public UserDetails UserDetails { get; set; }
        public int UserId { get; set; }
        public double Fare { get; set; }
        public bool IsPaymentDone { get; set; }
    }
}