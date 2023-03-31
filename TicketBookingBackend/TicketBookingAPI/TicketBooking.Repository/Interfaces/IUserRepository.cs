using TicketBooking.Models;

namespace TicketBooking.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<string> SaveUser(UserModel userModel);
    }
}
