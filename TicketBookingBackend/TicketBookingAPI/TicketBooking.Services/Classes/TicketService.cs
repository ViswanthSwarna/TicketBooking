using TicketBooking.Models;
using TicketBooking.Repository.Interfaces;
using TicketBooking.Services.Interfaces;

namespace TicketBooking.Services.Classes
{
    public class TicketService : ITicketService
    {
        private ITicketRepository _repository;
        public TicketService(ITicketRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> SaveTicket(TicketModel ticketmodel)
        {
            var result = await _repository.SaveTicket(ticketmodel);
            return result;
        }
    }
}
