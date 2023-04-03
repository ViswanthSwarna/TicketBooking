using AutoMapper;
using Microsoft.AspNetCore.Identity;
using TicketBooking.Data;
using TicketBooking.Domain;
using TicketBooking.Models;
using TicketBooking.Repository.Interfaces;

namespace TicketBooking.Repository.Classes
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<User> _userManager;

        public AuthenticationRepository(RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task<User?> FindByEmail(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }

        public async Task<IdentityResult> CreateAsync(User user, string password)
        {
            return await _userManager.CreateAsync(user, password);
        }

        public async Task<bool> RoleExistsAsync(string userRole)
        {
            return await _roleManager.RoleExistsAsync(userRole);
        }
        public async Task<IdentityResult> CreateAsync(IdentityRole identityRole)
        {
            return await _roleManager.CreateAsync(identityRole);
        }
        public async Task<IdentityResult> AddToRoleAsync(User user, string identityRole)
        {
            return await _userManager.AddToRoleAsync(user, identityRole);
        }

        public async Task<bool> CheckPasswordAsync(User user, string password)
        {
            return await _userManager.CheckPasswordAsync(user, password);
        }

        public async Task<IList<string>> GetRolesAsync(User user)
        {
            return await _userManager.GetRolesAsync(user);
        }
    }
}
