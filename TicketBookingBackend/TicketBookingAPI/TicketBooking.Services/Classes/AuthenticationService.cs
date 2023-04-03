using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TicketBooking.Domain;
using TicketBooking.Models;
using TicketBooking.Repository.Interfaces;
using TicketBooking.Services.Interfaces;
using TicketBookingDomain;

namespace TicketBooking.Services.Classes
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IMapper _mapper;
        private IAuthenticationRepository _authenticationRepository;
        public AuthenticationService(IMapper mapper, IAuthenticationRepository authenticationRepository)
        {
            _mapper = mapper;
            _authenticationRepository = authenticationRepository;
        }

        public async Task<bool> RegisterUser(UserModel userModel)
        {
            var userExist = await _authenticationRepository.FindByEmail(userModel.Email);
            if (userExist != null)
            {
                return false;
            }
            User user = new User()
            {
                Email = userModel.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = userModel.FullName,
                PhoneNumber = userModel.PhoneNumber,
                IsGuestUser = userModel.IsGuest
            };
            var result = await _authenticationRepository.CreateAsync(user, userModel.Password);
            if (result.Succeeded)
                return true;
            return false;
        }

        public async Task<bool> RegisterAdmin(UserModel userModel)
        {
            var userExist = await _authenticationRepository.FindByEmail(userModel.Email);
            if (userExist != null)
            {
                return false;
            }

            User user = new User()
            {
                Email = userModel.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = userModel.FullName,
                PhoneNumber = userModel.PhoneNumber
            };
            var result = await _authenticationRepository.CreateAsync(user, userModel.Password);
            if (!result.Succeeded)
                return false;
            if (!await _authenticationRepository.RoleExistsAsync(UserRoles.Admin))
                await _authenticationRepository.CreateAsync(new IdentityRole(UserRoles.Admin));
            if (!await _authenticationRepository.RoleExistsAsync(UserRoles.User))
                await _authenticationRepository.CreateAsync(new IdentityRole(UserRoles.User));

            if (await _authenticationRepository.RoleExistsAsync(UserRoles.Admin))
                await _authenticationRepository.AddToRoleAsync(user, UserRoles.Admin);
            
            return true;
        }

        public async Task<object> Login(LoginModel model, IConfiguration configuration)
        {
            var user = await _authenticationRepository.FindByEmail(model.Email);
            if (user != null && await _authenticationRepository.CheckPasswordAsync(user, model.Password))
            {
                var userRoles = await _authenticationRepository.GetRolesAsync(user);

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };
                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }
                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]));
                
                var token = new JwtSecurityToken(
                    issuer: configuration["JWT:ValidIssuer"],
                    audience: configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddDays(1),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                    );
                return new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                };

            }
            return new
            {
                status = "Fail",
                message = "Token creation failed!"
            };
        }
    }
}
