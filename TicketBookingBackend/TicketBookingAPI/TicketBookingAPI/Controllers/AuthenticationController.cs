using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TicketBooking.Domain;
using TicketBooking.Models;
using TicketBooking.Services.Interfaces;
using TicketBookingDomain;

namespace TicketBookingAPI.Controllers
{
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration _configuration;
        private readonly IAuthenticationServices _authenticationServices;

        public AuthenticationController(IAuthenticationServices authenticationService,UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            _authenticationServices = authenticationService;
            this.userManager = userManager;
            this.roleManager = roleManager;
            _configuration = configuration;
        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            return new OkObjectResult(await _authenticationServices.Login(model, _configuration));            
        }
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] UserModel model)
        {
            var result = await _authenticationServices.RegisterUser(model);
            if (result)
                return Ok("User created successfully!");
            else
                return BadRequest("User creation failed");
        }
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost]
        [Route("register-admin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] UserModel model)
        {
            var result = await _authenticationServices.RegisterAdmin(model);
            if(result)
                return Ok("User created successfully!");
            else
                return BadRequest("User creation failed");
        }
    }
}
