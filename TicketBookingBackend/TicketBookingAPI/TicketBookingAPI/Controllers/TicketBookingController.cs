using Microsoft.AspNetCore.Mvc;
using TicketBookingAPI.Model;
using TicketBookingAPI.Services;

namespace TicketBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketBookingController : Controller
    {
        private CityDetailsService _service;
        public TicketBookingController(CityDetailsService service) 
        { 
            _service= service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CityDetailsModel>>> GetAllCities() 
        {
            try 
            {
                var cities = await _service.GetAllCities();
                return Ok(cities);
            }catch(Exception ex) 
            { 
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAllCitiesLike/{pattern}")]
        public async Task<ActionResult<IEnumerable<CityDetailsModel>>> GetAllCitiesLike(string pattern)
        {
            try
            {
                var cities = await _service.GetAllCitiesLike(pattern);
                return Ok(cities);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
