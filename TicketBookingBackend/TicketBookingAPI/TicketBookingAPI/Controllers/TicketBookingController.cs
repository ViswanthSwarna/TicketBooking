using Microsoft.AspNetCore.Mvc;
using TicketBookingAPI.Interface;
using TicketBookingAPI.Model;

namespace TicketBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketBookingController : Controller
    {
        private ICityService _cityservice;
        private IBusService _busService;
        private ITicketService _ticketService;
        public TicketBookingController(ICityService cityService, IBusService busService, ITicketService ticketService)
        {
            _cityservice = cityService;
            _busService = busService;
            _ticketService = ticketService;
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

        //public async Task<ActionResult<bool>> SaveTicketForGuest(TicketModel ticketModel) 
        //{ 

        //}
    }
}
