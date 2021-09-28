using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KyustendilAPI.Models
{
    /// <summary>
    /// Database context for the place model
    /// </summary>
    public class LocationContext : IdentityDbContext
    {
        public LocationContext(DbContextOptions<LocationContext> options) : base(options) { }

        public DbSet<Location> Locations { get; set; } 
    }
}
