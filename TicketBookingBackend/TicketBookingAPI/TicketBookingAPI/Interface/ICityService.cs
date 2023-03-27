using NuGet.Protocol.Core.Types;
using TicketBookingAPI.Model;

namespace TicketBookingAPI.Interface
{
    public interface ICityService
    {
        Task<IEnumerable<CityModel>> GetAllCities();
        Task<IEnumerable<CityModel>> GetAllCitiesLike(string pattern);
        
    }
}
