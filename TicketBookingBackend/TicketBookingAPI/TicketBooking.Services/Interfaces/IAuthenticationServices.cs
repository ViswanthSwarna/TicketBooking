using Microsoft.Extensions.Configuration;
using TicketBooking.Domain;
using TicketBooking.Models;

namespace TicketBooking.Services.Interfaces
{
    public interface IAuthenticationServices
    {
        Task<bool> RegisterUser(UserModel userModel);
        Task<bool> RegisterAdmin(UserModel userModel);
        Task<object> Login(LoginModel model, IConfiguration configuration); 
    }
}
