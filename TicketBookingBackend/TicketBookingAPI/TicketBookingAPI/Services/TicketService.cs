using TicketBookingAPI.Model;
using TicketBookingAPI.Repository;

namespace TicketBookingAPI.Services
{
    public class TicketService
    {
        private TicketRepository _repository;
        public TicketService(TicketRepository repository)
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
