using TicketBooking.Models;

namespace TicketBookingAPI.Interface
{
    public interface IUserService
    {
        Task<int> SaveUser(UserModel userModel);
    }
}
