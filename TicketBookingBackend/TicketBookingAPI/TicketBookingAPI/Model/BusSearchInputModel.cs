using Microsoft.Build.Framework;

namespace TicketBookingAPI.Model
{
    public class BusSearchInputModel
    {
        public DateTime StartDate { get; set; }
        [Required]
        public string? SourceCity { get; set; }
        [Required]
        public string? DestinationCity { get; set; }
    }
}
