using TicketBookingAPI.Model;

namespace TicketBookingAPI.Interface
{
    public interface ICityRepository
    {
        Task<IEnumerable<CityModel>> GetAllCities();
        Task<IEnumerable<CityModel>> GetAllCitiesLike(string pattern);
    }
}
