namespace TicketBooking.Domain
{
    public class Ticket
    {
        public int Id { get; set; }
        public int BusId { get; set; }
        public Bus Bus { get; set; }
        public int UserId { get; set; }
        public ActiveUser User { get; set; }
        public double Fare { get; set; }
        public bool IsPaymentDone { get; set; }
    }
}