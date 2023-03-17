using TicketBookingAPI.Model;

namespace TicketBookingAPI.Interface
{
    public interface ITicketRepository
    {
        Task<bool> SaveTicket(TicketModel ticketModel);
    }
}
