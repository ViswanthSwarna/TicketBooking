using System.ComponentModel.DataAnnotations.Schema;
using TicketBooking.Domain;

namespace TicketBookingAPI.Model
{
    public class BusModel
    {
        public int Id { get; set; } 
        public string BusName { get; set; }
        public string Type { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public City SourceCity { get; set; }
        public City DestinationCity { get; set; }
    }
}
