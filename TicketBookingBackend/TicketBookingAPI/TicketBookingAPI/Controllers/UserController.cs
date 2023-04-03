using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TicketBooking.Models;
using TicketBooking.Services.Classes;
using TicketBooking.Services.Interfaces;

namespace TicketBookingAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        public UserController(IUserService userService) 
        { 
            _userService= userService;
        }

        [HttpPost()]
        public async Task<IActionResult> SaveUser(UserModel userModel)
        {
            var added = await _userService.SaveUser(userModel);
            return Ok(added);
        }
    }
}
