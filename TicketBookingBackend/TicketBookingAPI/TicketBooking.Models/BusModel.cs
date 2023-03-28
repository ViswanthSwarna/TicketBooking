using TicketBooking.Models;

namespace TicketBooking.Models
{
    public class BusModel
    {
        public int Id { get; set; } 
        public string BusName { get; set; }
        public string Type { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public CityModel SourceCity { get; set; }
        public CityModel DestinationCity { get; set; }
    }
}
