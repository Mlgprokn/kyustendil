using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KyustendilAPI.Models;
using KyustendilAPI.Models.DTOs.Requests.Location;
using KyustendilAPI.Models.DTOs.Responses.Location;

namespace KyustendilAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly LocationContext _context;

        public LocationsController(LocationContext context)
        {
            _context = context;
        }

        // GET: api/Locations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LocationResponse>>> GetLocations()
        {
            var locations = from l in await _context.Locations.ToListAsync()
                        select new LocationResponse()
                        {
                            Id = l.Id,
                            Title = l.Title,
                            Picture = l.Picture,
                            Information = l.Information
                        };

            return Ok(locations);
        }

        // GET: api/Locations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LocationResponse>> GetLocation(int id)
        {
            var location = await _context.Locations.FindAsync(id);

            if (location == null)
            {
                return NotFound();
            }

            var locRes = new LocationResponse
            {
                Id = location.Id,
                Title = location.Title,
                Picture = location.Picture,
                Information = location.Information
            };

            return Ok(locRes);
        }

        // PUT: api/Locations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult<LocationResponse>> PutLocation(int id, [FromForm] LocationDTO locationDTO)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            if (id != locationDTO.Id) return BadRequest();

            var location = new Location
            {
                Title = locationDTO.Title,
                Picture = locationDTO.Picture,
                Information = locationDTO.Picture
            };

            _context.Entry(location).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlaceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            var locRes = new LocationResponse
            {
                Id = location.Id,
                Title = location.Title,
                Picture = location.Picture,
                Information = location.Information
            };

            return Ok(locRes);
        }

        // POST: api/Locations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LocationResponse>> PostLocation([FromForm] LocationDTO locationDTO) 
        {
            var location = new Location
            {
                Title = locationDTO.Title,
                Picture = locationDTO.Picture,
                Information = locationDTO.Picture
            };

            _context.Locations.Add(location);
            await _context.SaveChangesAsync();

            var locRes = new LocationResponse
            {
                Id = location.Id,
                Title = location.Title,
                Picture = location.Picture,
                Information = location.Information
            };

            return CreatedAtAction(nameof(GetLocation), new { id = location.Id }, locRes);
        }

        // DELETE: api/Locations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LocationResponse>> DeleteLocation(int id)
        {
            var location = await _context.Locations.FindAsync(id);
            if (location == null)
            {
                return NotFound();
            }

            _context.Locations.Remove(location);
            await _context.SaveChangesAsync();

            var locRes = new LocationResponse
            {
                Id = location.Id,
                Title = location.Title,
                Picture = location.Picture,
                Information = location.Information
            };

            return Ok(locRes);
        }

        private bool PlaceExists(int id)
        {
            return _context.Locations.Any(e => e.Id == id);
        }
    }
}
