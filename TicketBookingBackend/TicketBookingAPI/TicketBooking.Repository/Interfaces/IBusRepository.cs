using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBooking.Domain;

namespace TicketBooking.Repository.Interfaces
{
    public interface IBusRepository:IGenericTicketBookingRepository<Bus>
    {
    }
}
