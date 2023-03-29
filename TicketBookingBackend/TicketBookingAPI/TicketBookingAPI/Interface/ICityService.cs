using NuGet.Protocol.Core.Types;
using TicketBooking.Models;

namespace TicketBookingAPI.Interface
{
    public interface ICityService
    {
        Task<IEnumerable<CityModel>> GetAllCities();
        Task<IEnumerable<CityModel>> GetAllCitiesLike(string pattern);
        
    }
}
