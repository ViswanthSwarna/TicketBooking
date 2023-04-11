using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Moq;
using TicketBooking.Data;
using TicketBooking.Domain;
using TicketBooking.Models;
using TicketBooking.Repository.Classes;
using TicketBooking.Repository.Interfaces;

namespace TicketBooking.Test.RepositoryTest
{
    public class CityRepositoryTest
    {
        private readonly ICityRepository _cityRepository;
        private readonly DbContextOptions<TicketManagemetContext> _contextOptions;
        private readonly TicketManagemetContext _context;
        private readonly IMapper _mapper;

        public CityRepositoryTest()
        {
            var mapperConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<City, CityModel>();
            });

            _mapper = mapperConfig.CreateMapper();

            _contextOptions = new DbContextOptionsBuilder<TicketManagemetContext>().UseInMemoryDatabase("TicketBookingTestDatabase").Options;

            _context = new TicketManagemetContext(_contextOptions);
            _cityRepository = new CityRepository(_context, _mapper);
        }

        [Fact]
        public async Task GetAllCities_ShouldReturnEmptyListWhenNoCitiesExist()
        {
            RemoveCitiesFromInMemoryDatabase();
            // Act
            var result = await _cityRepository.GetAllCities();

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public async Task GetAllCities_ShouldReturnAllCities()
        {
            // Arrange
            var cityList = AddCitiesToInMemoryDatabase().Result;

            // Act
            var result = await _cityRepository.GetAllCities();

            // Assert
            Assert.Equal(3, result.Count());
            Assert.Contains(result, c => c.Name == cityList[0].Name);
            Assert.Contains(result, c => c.Name == cityList[1].Name);
            Assert.Contains(result, c => c.Name == cityList[2].Name);
        }



        [Fact]
        public async Task GetAllCities_ShouldReturnAllCitiesLikeExistPattern()
        {
            // Arrange
            var cityList = AddCitiesToInMemoryDatabase().Result;
            var pattern = "Pune";
            // Act
            var result = await _cityRepository.GetAllCitiesLike(pattern);

            // Assert
            Assert.Equal(1, result.Count());
            Assert.Contains(result, c => c.Name == cityList[0].Name);
        }

        [Fact]
        public async Task GetAllCities_ShouldReturnEmptyWithNonExistingPattern()
        {
            // Arrange
            AddCitiesToInMemoryDatabase();
            string pattern = "Mum";
            // Act
            var result = await _cityRepository.GetAllCitiesLike(pattern);

            // Assert
            Assert.Empty(result);

        }

        private async Task<List<City>> AddCitiesToInMemoryDatabase()
        {
            RemoveCitiesFromInMemoryDatabase();

            var city1 = new City { Id = 1, Name = "Pune" };
            var city2 = new City { Id = 2, Name = "Bangalore" };
            var city3 = new City { Id = 3, Name = "Delhi" };
            var cityList = new List<City> { city1, city2, city3 };
            await _context.AddRangeAsync(cityList);
            await _context.SaveChangesAsync();
            return cityList;
        }

        private async void RemoveCitiesFromInMemoryDatabase()
        {
            var cities = await _context.City.ToListAsync();
            _context.City.RemoveRange(cities);
            await _context.SaveChangesAsync(); 
        }
    }
}
