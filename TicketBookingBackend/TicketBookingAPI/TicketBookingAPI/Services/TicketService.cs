using TicketBookingAPI.Interface;
using TicketBooking.Models;

namespace TicketBookingAPI.Services
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
