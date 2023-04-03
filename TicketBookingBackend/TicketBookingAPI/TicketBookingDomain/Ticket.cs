using System.ComponentModel.DataAnnotations.Schema;
using TicketBookingDomain;

namespace TicketBooking.Domain
{
    public class Ticket
    {
        public int Id { get; set; }
        public int BusId { get; set; }
        public Bus Bus { get; set; }
        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        public double Fare { get; set; }
        public bool IsPaymentDone { get; set; }
    }
}