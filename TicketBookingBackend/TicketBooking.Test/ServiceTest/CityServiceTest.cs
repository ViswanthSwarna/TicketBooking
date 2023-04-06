using Castle.Core.Smtp;
using Microsoft.AspNetCore.Mvc;
using Moq;
using TicketBooking.Models;
using TicketBooking.Repository.Interfaces;
using TicketBooking.Services.Classes;
using TicketBooking.Services.Interfaces;

namespace TicketBooking.Test.ServiceTest
{
    public class CityServiceTest
    {
        private readonly Mock<ICityRepository> _repository;
        private readonly ICityService _cityService;
        public CityServiceTest()
        {
            _repository = new Mock<ICityRepository>();
            _cityService = new CityService(_repository.Object);
        }

        [Fact]
        public async Task GetAllCities_Returns_All_Cities_When_No_Pattern() 
        {
            var expectedCities = GetTestCities();

            _repository.Setup(service => service.GetAllCities())
                .ReturnsAsync(expectedCities);

            var result = await _cityService.GetAllCities() as List<CityModel>;

            Assert.IsType<List<CityModel>>(result);
            Assert.Equal(expectedCities, result);
        }

        [Fact]
        public async Task GetAllCities_Returns_All_Cities_When_Pattern_Provided()
        {
            var expectedCities = new List<CityModel>
            {
                new CityModel { Id = 3, Name = "Mumbai" }
            };
            var pattern = "Mum";

            _repository.Setup(service => service.GetAllCitiesLike(pattern))
                .ReturnsAsync(expectedCities);

            var result = await _cityService.GetAllCitiesLike(pattern) as List<CityModel>;

            Assert.IsType<List<CityModel>>(result);
            Assert.Equal(expectedCities, result);
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
