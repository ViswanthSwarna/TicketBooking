using TicketBooking.Domain;

namespace TicketBooking.Repository.Interfaces
{
    public interface ICityRepository: IGenericTicketBookingRepository<City>
    {
        City FindIdByName(string name);
    }
}
