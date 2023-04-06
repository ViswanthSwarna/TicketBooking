using Moq;
using TicketBooking.Repository.Interfaces;
using TicketBooking.Services.Classes;
using TicketBooking.Services.Interfaces;

namespace TicketBooking.Test.ServiceTest
{
    public class TicketBookingServiceTest
    {
        private readonly Mock<ITicketRepository> _repository;

        private readonly ITicketService _ticketService;
        public TicketBookingServiceTest()
        {
            _repository = new Mock<ITicketRepository>();
            _ticketService = new TicketService(_repository.Object);
        }

        [Fact]
        public void SaveTicket_Returns_True() 
        { 
        
        }

        [Fact]
        public void SaveTicket_Returns_False()
        {

        }
    }
}