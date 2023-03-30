using TicketBooking.Models;

namespace TicketBooking.Services.Interfaces
{
    public interface IUserService
    {
        Task<int> SaveUser(UserModel userModel);
    }
}
