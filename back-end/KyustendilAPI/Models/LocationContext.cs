using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KyustendilAPI.Models
{
    /// <summary>
    /// Database context for the place model
    /// </summary>
    public class LocationContext : DbContext
    {
        public LocationContext(DbContextOptions<LocationContext> options) : base(options) { }

        public DbSet<Location> Locations { get; set; } 
    }
}
