using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBooking.Domain;
using TicketBooking.Models;

namespace TicketBooking.Services.Interfaces
{
    public interface IBusService
    {
        Task<int> AddBus(BusModel busModel);
        Task<int> DeleteBus(int id);
        Task<BusModel> GetBus(int id);
        Task<IEnumerable<BusModel>> GetBuses();
        Task<int> UpdateBus(BusModel busModel);

        Task<IEnumerable<BusModel>> GetBuses(BusSearchInputModel busSearchInput);
    }
}
