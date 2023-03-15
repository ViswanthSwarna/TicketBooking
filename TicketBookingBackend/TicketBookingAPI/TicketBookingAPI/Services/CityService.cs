using TicketBookingAPI.Model;
using TicketBookingAPI.Repository;

namespace TicketBookingAPI.Services
{
    public class CityService
    {
        private CityRepository _repository;
        public CityService(CityRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<CityModel>> GetAllCities()
        {
            var cities = await _repository.GetAllCities();
            return cities;
        }

        public async Task<IEnumerable<CityModel>> GetAllCitiesLike(string pattern)
        {
            var cities = await _repository.GetAllCitiesLike(pattern);
            return cities;
        }
    }
}
