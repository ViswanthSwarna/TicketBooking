using TicketBooking.Models;

namespace TicketBookingAPI.Interface
{
    public interface ITicketService
    {
        Task<bool> SaveTicket(TicketModel ticketmodel);
    }
}
