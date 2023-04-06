using Microsoft.AspNetCore.Mvc;
using Moq;
using TicketBooking.Domain;
using TicketBooking.Models;
using TicketBooking.Services.Interfaces;
using TicketBookingAPI.Controllers;

namespace TicketBooking.Test.ControllerTest
{
    public class TicketBookingControllerTest
    {
        private readonly Mock<ITicketService> _ticketServiceMock;
        private readonly Mock<IUserService> _userServiceMock;
        private readonly Mock<ICityService> _cityServiceMock;
        private readonly Mock<IBusService> _busServiceMock;

        private readonly TicketBookingController _controller;
        public TicketBookingControllerTest()
        {
            _ticketServiceMock = new Mock<ITicketService>();
            _busServiceMock = new Mock<IBusService>();
            _userServiceMock = new Mock<IUserService>();
            _cityServiceMock = new Mock<ICityService>();
            _controller = new TicketBookingController(_cityServiceMock.Object, _busServiceMock.Object, _ticketServiceMock.Object, _userServiceMock.Object);
        }

        [Fact]
        public async Task GetAllCities_Returns_All_Cities_When_No_Pattern()
        {
            // Arrange
            var expectedCities = GetTestCities();

            _cityServiceMock.Setup(service => service.GetAllCities())
                .ReturnsAsync(expectedCities);

            // Act
            var result = await _controller.GetAllCities(null);

            // Assert
            var okResult = Assert.IsType<ActionResult<IEnumerable<CityModel>>>(result);

            var res = okResult.Result as ObjectResult;

            var actualCities = Assert.IsType<List<CityModel>>(res.Value);
            Assert.Equal(expectedCities.Count, actualCities.Count);
        }

        [Fact]
        public async Task GetAllCities_Returns_Matching_Cities_When_Pattern_Provided()
        {
            // Arrange
            var expectedCities = new List<CityModel>
            {
                new CityModel { Id = 3, Name = "Mumbai" }
            };

            var pattern = "Mum";
            _cityServiceMock.Setup(service => service.GetAllCitiesLike(pattern))
                .ReturnsAsync(expectedCities);

            // Act
            var result = await _controller.GetAllCities(pattern);

            // Assert
            var okResult = Assert.IsType<ActionResult<IEnumerable<CityModel>>>(result);

            var res = okResult.Result as ObjectResult;

            var actualCities = Assert.IsType<List<CityModel>>(res.Value);
            Assert.Equal(expectedCities.Count, actualCities.Count);
        }

        private List<CityModel> GetTestCities()
        {
            return new List<CityModel>
            {
                new CityModel(){Id = 1, Name = "Dhule"},
                new CityModel(){Id = 2, Name = "Bangalore"},
                new CityModel(){Id = 3, Name = "Mumbai"},
                new CityModel(){Id = 4, Name = "Nashik"},
                new CityModel(){Id = 5, Name = "Pune"},
                new CityModel(){Id = 6, Name = "Delhi"},
                new CityModel(){Id = 7, Name = "Nagpur"},
                new CityModel(){Id = 8, Name = "Kanpur"},
                new CityModel(){Id = 9, Name = "Satara"},
                new CityModel(){Id = 10, Name = "Kolhapur"},
                new CityModel(){Id = 11, Name = "Vijaywada"},
            };
        }

    }
}

//7378963696