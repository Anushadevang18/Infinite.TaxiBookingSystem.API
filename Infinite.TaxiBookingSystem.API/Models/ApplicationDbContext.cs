using Microsoft.EntityFrameworkCore;

namespace Infinite.TaxiBookingSystem.API.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) :base(options)
        {

        }
        //add the table mapping
        public DbSet<Taxi> Taxis { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
