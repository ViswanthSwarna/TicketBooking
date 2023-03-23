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
        }
    }
}
