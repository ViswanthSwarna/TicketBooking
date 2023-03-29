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
    public class BusRepository : GenericTicketBookingRepository<Bus>, IBusRepository
    {
        private TicketManagemetContext _context;
        public BusRepository(TicketManagemetContext context) : base(context)
        {
            _context = context;
        }

        public override IEnumerable<Bus> GetAll()
        {
            var buses = _context.Bus
                .Include(bus => bus.DestinationCity)
                .Include(bus => bus.SourceCity)
                .ToList();
            return buses;
        }

        public override Bus? Find(object busId)
        {
            var bus = _context.Bus
                .Where(bus => bus.Id == (int)busId)
                .Select(bus => new Bus
                {
                    Id = bus.Id,
                    SourceCity = bus.SourceCity,
                    DestinationCity = bus.DestinationCity,
                    BusName = bus.BusName,
                    StartDateTime = bus.StartDateTime,
                    EndDateTime = bus.EndDateTime,
                    Type = bus.Type
                })
                .First();
            return bus;
        }
    }
}
