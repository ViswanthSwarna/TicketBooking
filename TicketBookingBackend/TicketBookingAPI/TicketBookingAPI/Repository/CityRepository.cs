using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TicketBooking.Data;
using TicketBookingAPI.Interface;
using TicketBookingAPI.Model;

namespace TicketBookingAPI.Repository
{
    public class CityRepository : ICityRepository
    {
        TicketManagemetContext _context;
        private IMapper _mapper;
        public CityRepository(TicketManagemetContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CityModel>> GetAllCities()
        {
            var cities = await _context.City.ToListAsync();
            var result = _mapper.Map<IEnumerable<CityModel>>(cities);
            return result;
        }

        public async Task<IEnumerable<CityModel>> GetAllCitiesLike(string pattern)
        {
            var cities = await _context.City.Where(city => EF.Functions.Like(city.Name, pattern + "%")).ToListAsync();
            var result = _mapper.Map<IEnumerable<CityModel>>(cities);
            return result;
        }
    }
}
