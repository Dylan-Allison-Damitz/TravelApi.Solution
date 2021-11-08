using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
  public class TravelApiContext : DbContext
  {
    public TravelApiContext(DbContextOptions<TravelApiContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Destination>()
          .HasData(
              new Destination { DestinationId = 1, Name = "Mt. Hood", City = "Government Camp", Country = "USA", Description = "Giant Volcano east of Portland, OR", Rating = 10 },
              new Destination { DestinationId = 2, Name = "Grand Canyon", City = "Grand Canyon Villge", Country = "USA", Description = "Large Desert Canyon in Arizona", Rating = 9 },
              new Destination { DestinationId = 3, Name = "Crater Lake", City = "Crater Lake", Country = "USA", Description = "Dormant Volcano with deep freshwater lake", Rating = 7 },
              new Destination { DestinationId = 4, Name = "Northwestern Park", City = "White Salmon", Country = "USA", Description  = "Put in for a really awesome section of whitewater kayaking", Rating = 8 },
              new Destination { DestinationId = 5, Name = "Barton Springs", City = "Austin", Country = "USA", Description  = "Spring fed swimming hole in the middle of downtown Austin", Rating = 10 }
          );
    }

    public DbSet<Destination> Destinations { get; set; }
  }
}