using TicketBooking.Models;
using TicketBooking.Repository.Interfaces;
using TicketBooking.Services.Interfaces;

namespace TicketBooking.Services.Classes
{
    public class CityService : ICityService
    {
        private ICityRepository _repository;
        public CityService(ICityRepository repository)
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
