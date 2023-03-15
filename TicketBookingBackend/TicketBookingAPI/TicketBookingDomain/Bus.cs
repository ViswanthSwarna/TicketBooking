using System.ComponentModel.DataAnnotations.Schema;

namespace TicketBooking.Domain
{
    public class Bus
    {
        public int Id { get; set; }
        public string BusName { get; set; }
        public string Type { get; set; }
        public int SourceCityId { get; set; }
        public int DestinationCityId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        [ForeignKey(nameof(SourceCityId))]
        public City SourceCityDetails { get; set; }
        [ForeignKey(nameof(DestinationCityId))]
        public City DestinationCityDetails { get; set; }
    }
}
