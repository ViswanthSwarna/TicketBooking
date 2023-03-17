using TicketBookingAPI.Model;

namespace TicketBookingAPI.Interface
{
    public interface IBusRepository
    {
        Task<IEnumerable<BusModel>> GetBuses();
        Task<IEnumerable<BusModel>> GetBuses(BusSearchInputModel busSearchInput);
    }
}
