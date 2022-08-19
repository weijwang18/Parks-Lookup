using Microsoft.EntityFrameworkCore;

namespace ParkFinder.Models
{
    public class ParkFinderContext : DbContext
    {
        public ParkFinderContext(DbContextOptions<ParkFinderContext> options)
            : base(options)
        {
        }

                protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Park>()
              .HasData(
                  new Park { ParkId = 1, Name = "Yosemite National Park", State = "CA" },
                  new Park { ParkId = 2, Name = "Grand Canyon National Park", State = "AZ" },
                  new Park { ParkId = 3, Name = "Arches National Park", State = "UT" }
              );
        }

        public DbSet<Park> Parks { get; set; }
    }
}