using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TicketBooking.Data;
using TicketBooking.Domain;
using TicketBookingAPI.Interface;
using TicketBookingAPI.Model;

namespace TicketBookingAPI.Repository
{
    public class TicketRepository : ITicketRepository
    {
        TicketManagemetContext _context;
        private IMapper _mapper;
        public TicketRepository(TicketManagemetContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<TicketModel> SaveTicket(TicketModel ticketModel)
        {
            var ticketEntry = _mapper.Map<Ticket>(ticketModel);
            _context.Entry(ticketEntry).State = EntityState.Added;
            var res = _context.SaveChanges();
            if(res > 0)
            {
                var ticketRes = await _context.Ticket
                    .Include(ticket => ticket.Bus)
                    .ThenInclude(city => city.SourceCity)
                    .Include(ticket => ticket.Bus)
                    .ThenInclude(city => city.DestinationCity)
                    .Where(ticket => ticket.Id == ticketEntry.Id).FirstOrDefaultAsync();
                ticketModel = _mapper.Map<TicketModel>(ticketRes);
                return ticketModel;
            }
            else 
            { 
                return null; 
            }
        }
    }
}
