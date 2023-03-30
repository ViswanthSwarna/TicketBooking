using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TicketBooking.Data;
using TicketBooking.Domain;
using TicketBooking.Models;
using TicketBooking.Repository.Interfaces;

namespace TicketBooking.Repository.Classes
{
    public class BusRepository : GenericTicketBookingRepository<Bus>, IBusRepository
    {
        private TicketManagemetContext _context;
        private IMapper _mapper;
        public BusRepository(TicketManagemetContext context, IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async override Task<IEnumerable<Bus>> GetAll()
        {
            var buses = await _context.Bus
                .Include(bus => bus.DestinationCity)
                .Include(bus => bus.SourceCity)
                .ToListAsync();
            return buses;
        }

        public async override Task<Bus?> Find(object busId)
        {
            var bus = await _context.Bus
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
                .FirstAsync();
            return bus;
        }

        public async Task<IEnumerable<BusModel>> GetBuses(BusSearchInputModel busSearchInput)
        {
            var buses = await _context.Bus
                .Where(bus =>
                bus.StartDateTime.Date == busSearchInput.StartDate.Date
                && bus.SourceCity.Name == busSearchInput.SourceCity
                && bus.DestinationCity.Name == busSearchInput.DestinationCity)
                .Select(bus => new BusModel
                {
                    Id = bus.Id,
                    SourceCity = _mapper.Map<CityModel>(bus.SourceCity),
                    DestinationCity = _mapper.Map<CityModel>(bus.DestinationCity),
                    BusName = bus.BusName,
                    StartDateTime = bus.StartDateTime,
                    EndDateTime = bus.EndDateTime,
                    Type = bus.Type
                })
                .ToListAsync();

            var result = _mapper.Map<IEnumerable<BusModel>>(buses);
            return result;
        }

        public async Task<IEnumerable<BusModel>> GetBuses()
        {

            var buses = await _context.Bus
                .Include(bus => bus.DestinationCity)
                .Include(bus => bus.SourceCity)
                .ToListAsync();
            var result = _mapper.Map<IEnumerable<BusModel>>(buses);
            return result;
        }

        public async Task<BusModel> GetBus(int busId)
        {
            //var bus = await _context.Bus.Where(bus => bus.Id == busId).FirstOrDefaultAsync();
            var bus = await _context.Bus
                .Where(bus => bus.Id == busId)
                .Select(bus => new BusModel
                {
                    Id = bus.Id,
                    SourceCity = _mapper.Map<CityModel>(bus.SourceCity),
                    DestinationCity = _mapper.Map<CityModel>(bus.DestinationCity),
                    BusName = bus.BusName,
                    StartDateTime = bus.StartDateTime,
                    EndDateTime = bus.EndDateTime,
                    Type = bus.Type
                })
                .FirstAsync();

            var result = _mapper.Map<BusModel>(bus);

            return result;
        }


    }
}
