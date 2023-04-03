using Microsoft.Extensions.Configuration;
using TicketBooking.Domain;
using TicketBooking.Models;

namespace TicketBooking.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<bool> RegisterUser(UserModel userModel);
        Task<bool> RegisterAdmin(UserModel userModel);
        Task<object> Login(LoginModel model, IConfiguration configuration); 
    }
}
