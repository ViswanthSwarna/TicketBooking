namespace TicketBookingAPI.Model
{
    public class BusSearchInputModel
    {
        public DateTime StartDate { get; set; }
        public int SourceCityId { get; set; }
        public int DestinationCityId { get; set; }
    }
}
