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
        public async Task<IActionResult> GetBuses()
        {
            var buses = await _busService.GetBuses();
            return Ok(buses);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBus(int id)
        {
            var bus = await _busService.GetBus(id);
            return Ok(bus);
        }

        [HttpPost()]
        public async Task<IActionResult> AddBus(BusModel busModel)
        {
            var added = await _busService.AddBus(busModel);
            return Ok(added);
        }

        [HttpPut()]
        public async Task<IActionResult> UpdateBus(BusModel busModel)
        {
            var updated = await _busService.UpdateBus(busModel);
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBus(int id)
        {
            var deleted = await _busService.DeleteBus(id);
            return Ok(deleted);
        }

    }
}
