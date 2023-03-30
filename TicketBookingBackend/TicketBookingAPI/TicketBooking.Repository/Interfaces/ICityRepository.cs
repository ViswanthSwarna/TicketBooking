using TicketBooking.Domain;
using TicketBooking.Models;

namespace TicketBooking.Repository.Interfaces
{
    public interface ICityRepository: IGenericTicketBookingRepository<City>
    {
        Task<City?> FindIdByName(string name);
        Task<IEnumerable<CityModel>> GetAllCities();
        Task<IEnumerable<CityModel>> GetAllCitiesLike(string pattern);
    }
}
