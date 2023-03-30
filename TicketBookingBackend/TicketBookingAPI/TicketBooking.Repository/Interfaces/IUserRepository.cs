using TicketBooking.Models;

namespace TicketBooking.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<int> SaveUser(UserModel userModel);
    }
}
