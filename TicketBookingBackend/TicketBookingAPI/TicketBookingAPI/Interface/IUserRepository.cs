using TicketBookingAPI.Model;

namespace TicketBookingAPI.Interface
{
    public interface IUserRepository
    {
        Task<int> SaveUser(UserModel userModel);
    }
}
