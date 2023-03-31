using Microsoft.AspNetCore.Identity;

namespace TicketBooking.Domain
{
    public class User : IdentityUser
    {
        public bool IsGuestUser { get; set; }
    }
}
