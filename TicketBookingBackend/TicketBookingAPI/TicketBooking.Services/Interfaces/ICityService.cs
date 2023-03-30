using TicketBooking.Models;

namespace TicketBooking.Services.Interfaces
{
    public interface ICityService
    {
        Task<IEnumerable<CityModel>> GetAllCities();
        Task<IEnumerable<CityModel>> GetAllCitiesLike(string pattern);
        
    }
}
