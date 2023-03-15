using TicketBookingAPI.Model;
using TicketBookingAPI.Repository;

namespace TicketBookingAPI.Services
{
    public class CityDetailsService
    {
        private CityDetailsRepository _repository;
        public CityDetailsService(CityDetailsRepository repository) 
        { 
            _repository = repository;
        }

        public async Task<IEnumerable<CityDetailsModel>> GetAllCities() 
        {
            var cities = await _repository.GetAllCities();
            return cities;
        }

        public async Task<IEnumerable<CityDetailsModel>> GetAllCitiesLike(string pattern)
        {
            var cities = await _repository.GetAllCitiesLike(pattern);
            return cities;
        }
    }
}
