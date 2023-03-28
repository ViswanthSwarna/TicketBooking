using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TicketBooking.Data;
using TicketBooking.Domain;
using TicketBookingAPI.Interface;
using TicketBooking.Models;

namespace TicketBookingAPI.Repository
{
    public class BusRepository : IBusRepository
    {
        private TicketManagemetContext _context;
        private IMapper _mapper;
        public BusRepository(TicketManagemetContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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

