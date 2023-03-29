using TicketBooking.Models;

namespace TicketBookingAPI.Interface
{
    public interface ITicketRepository
    {
        Task<bool> SaveTicket(TicketModel ticketModel);
    }
}
