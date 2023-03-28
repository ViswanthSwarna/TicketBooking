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
        int AddBus(BusModel busModel);

        int DeleteBus(int id);

        BusModel GetBus(int id);

        IEnumerable<BusModel> GetBuses();

        int UpdateBus(BusModel busModel);
    }
}
