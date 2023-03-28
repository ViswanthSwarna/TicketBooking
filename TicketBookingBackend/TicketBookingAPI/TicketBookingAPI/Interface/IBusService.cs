using TicketBooking.Models;

namespace TicketBookingAPI.Interface
{
    public interface IBusService
    {
        Task<IEnumerable<BusModel>> GetBuses(BusSearchInputModel busSearchInput);
        Task<IEnumerable<BusModel>> GetBuses();
        Task<BusModel> GetBus(int busId);
        
    }
}
