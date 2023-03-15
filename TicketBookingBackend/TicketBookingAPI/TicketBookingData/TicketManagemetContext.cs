using Microsoft.EntityFrameworkCore;
using TicketBooking.Domain;

namespace TicketBooking.Data
{
    public class TicketManagemetContext : DbContext
    {
        public DbSet<City> City { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Bus> Bus { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public TicketManagemetContext(DbContextOptions<TicketManagemetContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}