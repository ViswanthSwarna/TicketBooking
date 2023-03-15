using Microsoft.AspNetCore.Mvc;
using TicketBookingAPI.Model;
using TicketBookingAPI.Services;

namespace TicketBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketBookingController : Controller
    {
        private CityService _service;
        public TicketBookingController(CityService service)
        {
            _service = service;
        }

        [HttpGet("/{pattern}")]
        public async Task<ActionResult<IEnumerable<CityModel>>> GetAllCities(string pattern)
        {
            var cities = await _service.GetAllCitiesLike(pattern);
            return Ok(cities);
        }
    }
}
