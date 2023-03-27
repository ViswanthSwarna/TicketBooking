using TicketBookingAPI.Interface;
using TicketBookingAPI.Model;

namespace TicketBookingAPI.Services
{
    public class BusService : IBusService
    {
        private IBusRepository _repository;
        public BusService(IBusRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<BusModel>> GetBuses(BusSearchInputModel busSearchInput)
        {
            var cities = await _repository.GetBuses(busSearchInput);
            return cities;
        }
        public async Task<IEnumerable<BusModel>> GetBuses()
        {
            var cities = await _repository.GetBuses();
            return cities;
        }

        public async Task<BusModel> GetBus(int busId) 
        { 
            var bus = await _repository.GetBus(busId);
            return bus;
        }
    }
}
