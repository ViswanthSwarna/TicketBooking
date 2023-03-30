using TicketBooking.Models;

namespace TicketBooking.Services.Interfaces
{
    public interface ITicketService
    {
        Task<bool> SaveTicket(TicketModel ticketmodel);
    }
}
