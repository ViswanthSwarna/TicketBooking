using TicketBookingAPI.Model;

namespace TicketBookingAPI.Interface
{
    public interface IUserService
    {
        Task<int> SaveUser(UserModel userModel);
    }
}
