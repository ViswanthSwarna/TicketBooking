using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBooking.Data;
using TicketBooking.Domain;
using TicketBooking.Models;
using TicketBooking.Repository.Interfaces;

namespace TicketBooking.Repository.Classes
{
    public class CityRepository : GenericTicketBookingRepository<City>, ICityRepository
    {
        private readonly TicketManagemetContext _context;
        private readonly IMapper _mapper;
        public CityRepository(TicketManagemetContext context, IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<City?> FindIdByName(string name)
        {
            var bus = await _context.City.Where(city => city.Name == name).FirstOrDefaultAsync();
            return bus;
        }

        public async Task<IEnumerable<CityModel>> GetAllCities()
        {
            var cities = await _context.City.ToListAsync();
            var result = _mapper.Map<IEnumerable<CityModel>>(cities);
            return result;
        }

        public async Task<IEnumerable<CityModel>> GetAllCitiesLike(string pattern)
        {
            var cities = await _context.City
                .Where(city => EF.Functions
                    .Like(city.Name, pattern + "%"))
                .ToListAsync();
            var result = _mapper.Map<IEnumerable<CityModel>>(cities);
            return result;
        }
    }
}
