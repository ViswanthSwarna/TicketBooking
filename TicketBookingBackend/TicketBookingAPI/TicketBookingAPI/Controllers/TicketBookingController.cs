using Microsoft.AspNetCore.Mvc;
using TicketBookingAPI.Model;
using TicketBookingAPI.Services;

namespace TicketBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketBookingController : Controller
    {
        private CityService _cityservice;
        private BusService _busService;
        private TicketService _ticketService;
        public TicketBookingController(CityService cityService,BusService busService, TicketService ticketService)
        {
            _cityservice = cityService;
            _busService = busService;
            _ticketService = ticketService;
        }

        [HttpGet("/{pattern?}")]
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

        [HttpPost("SaveTicket")]
        public async Task<ActionResult<bool>> SaveTicket(TicketModel ticketModel) 
        {
            var res = await _ticketService.SaveTicket(ticketModel);
            return Ok(res);
        }
    }
}
