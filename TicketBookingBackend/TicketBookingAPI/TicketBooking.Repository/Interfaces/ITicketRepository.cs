using TicketBooking.Models;

namespace TicketBooking.Repository.Interfaces
{
    public interface ITicketRepository
    {
        Task<bool> SaveTicket(TicketModel ticketModel);
    }
}
