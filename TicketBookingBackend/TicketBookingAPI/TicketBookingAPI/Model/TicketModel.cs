using TicketBooking.Domain;

namespace TicketBookingAPI.Model
{
    public class TicketModel
    {
        public int BusId { get; set; }
        public int UserId { get; set; }
        public double Fare { get; set; }
        public bool IsPaymentDone { get; set; }
        public UserModel User { get; set; }
        public BusModel Bus { get; set; }
    }

}
