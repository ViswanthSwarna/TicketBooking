using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TicketBooking.Domain;
using TicketBooking.Models;
using TicketBooking.Services.Interfaces;
using TicketBookingDomain;

namespace TicketBookingAPI.Controllers
{
    public class AuthenticationController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService, IConfiguration configuration)
        {
            _authenticationService = authenticationService;
            _configuration = configuration;
        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            return Ok(await _authenticationService.Login(model, _configuration));
        }
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] UserModel model)
        {
            var result = await _authenticationService.RegisterUser(model);
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
            var result = await _authenticationService.RegisterAdmin(model);
            if (result)
                return Ok("User created successfully!");
            else
                return BadRequest("User creation failed");
        }
    }
}
