using TicketBooking.Models;

namespace TicketBookingAPI.Interface
{
    public interface ICityRepository
    {
        Task<IEnumerable<CityModel>> GetAllCities();
        Task<IEnumerable<CityModel>> GetAllCitiesLike(string pattern);
    }
}
