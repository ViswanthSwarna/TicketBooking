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
        public async Task<TicketModel> SaveTicket(TicketModel ticketmodel)
        {
            var ticketModel = await _repository.SaveTicket(ticketmodel);
            return ticketModel;
        }
    }
}
