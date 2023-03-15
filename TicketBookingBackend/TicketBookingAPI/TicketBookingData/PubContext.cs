using Microsoft.EntityFrameworkCore;
using TicketBookingDomain;

namespace TicketBookingData
{
    public class PubContext : DbContext
    {
        public DbSet<CityDetails> CityDetails { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<BusDetails> BusDetails { get; set; }
        public DbSet<TicketDetails> TicketDetails { get; set; }
        public PubContext(DbContextOptions<PubContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}