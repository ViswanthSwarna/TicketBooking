using Microsoft.AspNetCore.Mvc;
using TicketBooking.Models;
using TicketBooking.Services.Interfaces;

namespace TicketBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private IBusService _busService;
        public BusController(IBusService busService)
        {
            _busService = busService;
        }

        [HttpGet]
        public IActionResult GetBuses()
        {
            var buses = _busService.GetBuses();
            return Ok(buses);
        }

        [HttpGet("{id}")]
        public IActionResult GetBus(int id)
        {
            var bus = _busService.GetBus(id);
            return Ok(bus);
        }

        [HttpPost()]
        public IActionResult AddBus(BusModel busModel)
        {
            var added = _busService.AddBus(busModel);
            return Ok(added);
        }

        [HttpPut()]
        public IActionResult UpdateBus(BusModel busModel)
        {
            var updated = _busService.UpdateBus(busModel);
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBus(int id)
        {
            var deleted = _busService.DeleteBus(id);
            return Ok(deleted);
        }

    }
}
