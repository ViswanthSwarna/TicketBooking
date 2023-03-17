using NuGet.Protocol.Core.Types;
using TicketBookingAPI.Model;
using TicketBookingAPI.Repository;

namespace TicketBookingAPI.Services
{
    public class BusService
    {
        private BusRepository _repository;
        public BusService(BusRepository repository)
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
    }
}
