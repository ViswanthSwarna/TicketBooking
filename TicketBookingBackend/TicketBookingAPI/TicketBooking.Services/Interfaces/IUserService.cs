using TicketBooking.Models;

namespace TicketBooking.Services.Interfaces
{
    public interface IUserService
    {
        Task<string> SaveUser(UserModel userModel);
    }
}
