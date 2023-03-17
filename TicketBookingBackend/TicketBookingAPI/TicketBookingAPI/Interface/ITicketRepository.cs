using TicketBookingAPI.Model;

namespace TicketBookingAPI.Interface
{
    public interface ITicketRepository
    {
        Task<TicketModel> SaveTicket(TicketModel ticketModel);
    }
}
