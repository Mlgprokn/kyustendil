using kyustendil.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kyustendil.Data
{
    public interface ILocationsRepo
    {
        IEnumerable<Location> GetLocations();

        Location GetLocation(int id);
    }
}
