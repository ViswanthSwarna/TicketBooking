using TicketBookingAPI.Interface;
using TicketBookingAPI.Repository;
using TicketBookingAPI.Services;

namespace TicketBookingAPI.Extensions
{
    public static class RegisterDependenciesExtension
    {
        public static void AddDependencies(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<ICityRepository, CityRepository>();
            builder.Services.AddScoped<ICityService, CityService>();
            builder.Services.AddScoped<IBusRepository, BusRepository>();
            builder.Services.AddScoped<IBusService, BusService>();
            builder.Services.AddScoped<ITicketService, TicketService>();
            builder.Services.AddScoped<ITicketRepository, TicketRepository>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();

            builder.Services.AddScoped<TicketBooking.Services.Interfaces.IBusService,TicketBooking.Services.Classes.BusService>();
            builder.Services.AddScoped<TicketBooking.Repository.Interfaces.IBusRepository, TicketBooking.Repository.Classes.BusRepository>();
            builder.Services.AddScoped<TicketBooking.Repository.Interfaces.ICityRepository, TicketBooking.Repository.Classes.CityRepository>();

        }
    }
}
