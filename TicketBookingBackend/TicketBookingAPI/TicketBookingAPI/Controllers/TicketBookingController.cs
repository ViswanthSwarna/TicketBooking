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
        public TicketBookingController(CityService cityService,BusService busService)
        {
            _cityservice = cityService;
            _busService = busService;
        }

        [HttpGet("/{pattern}")]
        public async Task<ActionResult<IEnumerable<CityModel>>> GetAllCities(string pattern)
        {
            var cities = await _cityservice.GetAllCitiesLike(pattern);
            return Ok(cities);
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
    }
}
