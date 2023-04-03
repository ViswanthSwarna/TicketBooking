using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBooking.Domain;

namespace TicketBooking.Repository.Interfaces
{
    public interface IAuthenticationRepository 
    {
        Task<User?> FindByEmail(string email);
        Task<bool> CheckPasswordAsync(User user, string password);
        Task<IdentityResult> CreateAsync(User user, string password);
        Task<bool> RoleExistsAsync(string userRole);
        Task<IdentityResult> CreateAsync(IdentityRole identityRole);
        Task<IdentityResult> AddToRoleAsync(User user, string identityRole);

        Task<IList<string>> GetRolesAsync(User user);
    }
}
