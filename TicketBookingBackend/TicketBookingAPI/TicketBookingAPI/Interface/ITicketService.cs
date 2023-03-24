using TicketBookingAPI.Model;

namespace TicketBookingAPI.Interface
{
    public interface ITicketService
    {
        Task<bool> SaveTicket(TicketModel ticketmodel);
    }
}
