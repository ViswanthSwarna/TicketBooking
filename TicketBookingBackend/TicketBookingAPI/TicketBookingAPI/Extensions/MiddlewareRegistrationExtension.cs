using TicketBookingAPI.Middleware;

namespace TicketBookingAPI.Extensions
{
    public static class MiddlewareRegistrationExtension
    {
        public static void UseAppException(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<CustomExceptionMiddleware>();
        }

    }    
}
