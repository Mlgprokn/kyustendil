using kyustendil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kyustendil.Data
{
    public class MockLocationsRepo : ILocationsRepo
    {
        public IEnumerable<Location> GetLocations()
        {
            return new List<Location>
            {
                new Location { Id = 1, Information = "Chuval sum go", Picture=null, Title="Ludo mesto" },
                new Location { Id = 2, Information = "Ne sum go Chuval sum go", Picture=null, Title="Ludo meso" },
                new Location { Id = 3, Information = "Ludar Chuval sum go", Picture=null, Title="Ludo meso konsko" }    
            };
        }

        public Location GetLocation(int id)
        {
            return new Location { Id = 1, Information = "Chuval sum go", Picture=null, Title="Ludo mesto" };
        }

    }
}
