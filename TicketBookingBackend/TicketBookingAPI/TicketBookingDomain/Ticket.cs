namespace TicketBooking.Domain
{
    public class Ticket
    {
        public int Id { get; set; }
        public Bus BusDetails { get; set; }
        public int BusId { get; set; }
        public User UserDetails { get; set; }
        public int UserId { get; set; }
        public double Fare { get; set; }
        public bool IsPaymentDone { get; set; }
    }
}