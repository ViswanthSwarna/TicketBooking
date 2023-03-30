using Microsoft.EntityFrameworkCore;
using TicketBooking.Domain;

namespace TicketBookingData
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var users = new User[]
                {
                    new User () {Id = 1, FullName = "Rakesh Salunkhe", Email = "R.Salunkhe@devon.nl",PhoneNumber = "860019111", IsAdmin = true, IsGuestUser = false, IsLoggedIn = false, Password = "123123"},
                    new User () {Id = 2, FullName = "M M M", Email = "M.Mummmm@devon.nl",PhoneNumber = "860019111", IsAdmin = false, IsGuestUser = false, IsLoggedIn = false, Password = "123123"},
                    new User () {Id = 3, FullName = "C C C", Email = "C.cccccc@devon.nl",PhoneNumber = "860019111", IsAdmin = true, IsGuestUser = false, IsLoggedIn = false, Password = "123123"}
                 };
            var cities = new City[]
            {
                new City(){Id = 1, Name = "Dhule"},
                new City(){Id = 2, Name = "Bangalore"},
                new City(){Id = 3, Name = "Mumbai"},
                new City(){Id = 4, Name = "Nashik"},
                new City(){Id = 5, Name = "Pune"},
                new City(){Id = 6, Name = "Delhi"},
                new City(){Id = 7, Name = "Nagpur"},
                new City(){Id = 8, Name = "Kanpur"},
                new City(){Id = 9, Name = "Satara"},
                new City(){Id = 10, Name = "Kolhapur"},
                new City(){Id = 11, Name = "Vijaywada"},
            };
            var buses = new Bus[]
                {
                    new Bus(){Id = 1, BusName = "Rajdhani", Type = "Delux", SourceCityId = cities[0].Id, DestinationCityId = cities[1].Id, StartDateTime = new DateTime(2023,10,05), EndDateTime = new DateTime(2023, 10, 06)},
                    new Bus(){Id = 2, BusName = "Rajdhani001", Type = "SuperDelux", SourceCityId = cities[1].Id, DestinationCityId = cities[2].Id, StartDateTime = new DateTime(2023,11,05), EndDateTime = new DateTime(2023, 11, 06)},
                    new Bus(){Id = 3, BusName = "Rajdhani002", Type = "Delux", SourceCityId = cities[2].Id,DestinationCityId = cities[3].Id, StartDateTime = new DateTime(2023,12,05), EndDateTime = new DateTime(2023, 12, 06)},
                    new Bus(){Id = 4, BusName = "Rajdhani003", Type = "SuperDelux", SourceCityId = cities[3].Id, DestinationCityId = cities[4].Id, StartDateTime = new DateTime(2023,03,05), EndDateTime = new DateTime(2023, 04, 06)},
                    new Bus(){Id = 5, BusName = "Rajdhani004", Type = "Normal", SourceCityId = cities[4].Id, DestinationCityId = cities[5].Id, StartDateTime = new DateTime(2023,04,05), EndDateTime = new DateTime(2023, 04, 06)},
                    new Bus(){Id = 6, BusName = "Rajdhani005", Type = "DeluxSleeper", SourceCityId = cities[5].Id, DestinationCityId = cities[6].Id, StartDateTime = new DateTime(2023,05,05), EndDateTime = new DateTime(2023, 05, 06)}
                };
            var tickets = new Ticket[]
            {
                new Ticket() {Id = 1, Fare = 200, BusId = buses[0].Id, UserId = users[0].Id, IsPaymentDone = true},
                new Ticket() {Id = 2, Fare = 200, BusId = buses[1].Id, UserId = users[1].Id, IsPaymentDone = false},
                new Ticket() {Id = 3, Fare = 200, BusId = buses[2].Id, UserId = users[2].Id, IsPaymentDone = true},
                new Ticket() {Id = 4, Fare = 200, BusId = buses[3].Id, UserId = users[0].Id, IsPaymentDone = false},
                new Ticket() {Id = 5, Fare = 200, BusId = buses[0].Id, UserId = users[2].Id, IsPaymentDone = true},
                new Ticket() {Id = 6, Fare = 200, BusId = buses[2].Id, UserId = users[1].Id, IsPaymentDone = false},
            };
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<City>().HasData(cities);
            modelBuilder.Entity<Bus>().HasData(buses);
            modelBuilder.Entity<Ticket>().HasData(tickets);
        }
    }
}
