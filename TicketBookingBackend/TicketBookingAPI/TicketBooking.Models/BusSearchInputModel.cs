using System.ComponentModel.DataAnnotations;

namespace TicketBooking.Models
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
