using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBooking.Data;
using TicketBooking.Domain;
using TicketBooking.Repository.Interfaces;

namespace TicketBooking.Repository.Classes
{
    public class CityRepository : GenericTicketBookingRepository<City>, ICityRepository
    {
        private readonly TicketManagemetContext _context;
        public CityRepository(TicketManagemetContext context) : base(context)
        {
            _context = context;
        }

        public City FindIdByName(string name)
        {
            var bus = _context.City.Where(city => city.Name == name).FirstOrDefault();
            return bus;
        }
    }
}
