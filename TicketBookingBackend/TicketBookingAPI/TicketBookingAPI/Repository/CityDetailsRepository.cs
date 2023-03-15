using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TicketBookingAPI.Interface;
using TicketBookingAPI.Model;
using TicketBookingData;

namespace TicketBookingAPI.Repository
{
    public class CityDetailsRepository : ICityDetailsRepository
    {
        PubContext _context;
        private IMapper _mapper;
        public CityDetailsRepository(PubContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CityDetailsModel>> GetAllCities()
        {
            var cities = await _context.CityDetails.ToListAsync();
            var result = _mapper.Map<IEnumerable<CityDetailsModel>>(cities);
            return result;
        }
    
        public async Task<IEnumerable<CityDetailsModel>> GetAllCitiesLike(string pattern)
        {
            var cities = await _context.CityDetails.Where(city => EF.Functions.Like(city.Name,pattern+"%")).ToListAsync();
            var result = _mapper.Map<IEnumerable<CityDetailsModel>>(cities);
            return result;
        }
    }
}
