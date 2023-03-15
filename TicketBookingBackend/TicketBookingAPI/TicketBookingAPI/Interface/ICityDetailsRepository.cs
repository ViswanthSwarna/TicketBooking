using TicketBookingAPI.Model;
using TicketBookingDomain;

namespace TicketBookingAPI.Interface
{
    public interface ICityDetailsRepository
    {
        Task<IEnumerable<CityDetailsModel>> GetAllCities();
        Task<IEnumerable<CityDetailsModel>> GetAllCitiesLike(string pattern);
    }
}
