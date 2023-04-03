using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TicketBooking.Domain;
using TicketBookingData;
using TicketBookingDomain;

namespace TicketBooking.Data
{
    public class TicketManagemetContext : IdentityDbContext<User>
    {
        public DbSet<City> City { get; set; }
        public DbSet<Bus> Bus { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public TicketManagemetContext(DbContextOptions<TicketManagemetContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}