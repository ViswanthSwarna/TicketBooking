using TicketBookingAPI.Middleware;
using TicketBookingAPI.Repository;
using TicketBookingAPI.Services;

namespace TicketBookingAPI.Extensions
{
    public static class RegisterDependenciesExtension
    {
        public static void AddDependencies(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<CityRepository>();
            builder.Services.AddScoped<CityService>();
            builder.Services.AddScoped<BusRepository>();
            builder.Services.AddScoped<BusService>();
            builder.Services.AddScoped<TicketService>();
            builder.Services.AddScoped<TicketRepository>();
        }
    }
}
