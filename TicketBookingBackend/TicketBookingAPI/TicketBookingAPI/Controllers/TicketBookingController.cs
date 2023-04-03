using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using TicketBooking.Models;
using TicketBooking.Services.Interfaces;

namespace TicketBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketBookingController : Controller
    {
        private ICityService _cityservice;
        private IBusService _busService;
        private ITicketService _ticketService;
        private IUserService _userService;
        public TicketBookingController(ICityService cityService, IBusService busService, ITicketService ticketService, IUserService userService)
        {
            _cityservice = cityService;
            _busService = busService;
            _ticketService = ticketService;
            _userService = userService;
        }

        [HttpGet("GetAllCities/{pattern?}")]
        public async Task<ActionResult<IEnumerable<CityModel>>> GetAllCities(string pattern)
        {
            if (string.IsNullOrWhiteSpace(pattern))
            {
                var cities = await _cityservice.GetAllCities();
                return Ok(cities);
            }
            else 
            {
                var cities = await _cityservice.GetAllCitiesLike(pattern);
                return Ok(cities);
            }
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<BusModel>>> GetBuses(BusSearchInputModel busSearchInput)
        {
            var cities = await _busService.GetBuses(busSearchInput);
            return Ok(cities);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BusModel>>> GetBuses()
        {
            var cities = await _busService.GetBuses();
            return Ok(cities);
        }
        [HttpGet("GetBus")]
        public async Task<ActionResult<BusModel>> GetBus(int busId)
        {
            var bus = await _busService.GetBus(busId);
            return Ok(bus);
        }

        [Authorize]
        [HttpPost("SaveTicket")]
        public async Task<ActionResult<bool>> SaveTicket(TicketModel ticketModel)
        {
            var res = await _ticketService.SaveTicket(ticketModel);
            return Ok(res);
        }

        [HttpPost("SaveTicketForGuest")]
        public async Task<ActionResult<bool>> SaveTicketForGuest(Dictionary<string, object> data)
        {
            bool res = false;
            string userId = string.Empty;
            var userModel = (UserModel)data["UserModel"];
            var ticketModel = (TicketModel)data["TicketModel"];
            if (userModel != null)
            {
                userId = await _userService.SaveUser(userModel);
            }
            if (userId.IsNullOrEmpty())
            {
                ticketModel.UserId = userId;
                res = await _ticketService.SaveTicket(ticketModel);
            }
            else
                return BadRequest(res);
            return Ok(res);
        }
    }
}
