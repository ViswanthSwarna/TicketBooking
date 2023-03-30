using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TicketBooking.Data;
using TicketBooking.Domain;
using TicketBooking.Models;
using TicketBooking.Repository.Interfaces;

namespace TicketBooking.Repository.Classes
{
    public class TicketRepository : ITicketRepository
    {
        private TicketManagemetContext _context;
        private IMapper _mapper;
        public TicketRepository(TicketManagemetContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> SaveTicket(TicketModel ticketModel)
        {
            var ticketEntry = _mapper.Map<Ticket>(ticketModel);
            _context.Entry(ticketEntry).State = EntityState.Added;
            var res = _context.SaveChanges();
            return res > 0 ? true : false;
        }
    }
}
