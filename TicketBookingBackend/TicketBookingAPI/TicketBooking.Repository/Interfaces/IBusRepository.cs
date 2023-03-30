using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBooking.Domain;
using TicketBooking.Models;

namespace TicketBooking.Repository.Interfaces
{
    public interface IBusRepository:IGenericTicketBookingRepository<Bus>
    {
        Task<IEnumerable<BusModel>> GetBuses(BusSearchInputModel busSearchInput);

        Task<IEnumerable<BusModel>> GetBuses();
        Task<BusModel> GetBus(int busId);
    }
}
