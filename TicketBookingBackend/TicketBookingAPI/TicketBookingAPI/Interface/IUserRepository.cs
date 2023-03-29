using TicketBooking.Models;

namespace TicketBookingAPI.Interface
{
    public interface IUserRepository
    {
        Task<int> SaveUser(UserModel userModel);
    }
}
