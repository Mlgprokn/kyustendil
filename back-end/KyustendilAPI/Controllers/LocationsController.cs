using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KyustendilAPI.Models;

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

        // GET: api/Places
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Location>>> GetPlaces()
        {
            return await _context.Locations.ToListAsync();
        }

        // GET: api/Places/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Location>> GetPlace(int id)
        {
            var place = await _context.Locations.FindAsync(id);

            if (place == null)
            {
                return NotFound();
            }

            return place;
        }

        // PUT: api/Places/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult<Location>> PutPlace(int id, Location place)
        {
            if (id != place.Id)
            {
                return BadRequest();
            }

            _context.Entry(place).State = EntityState.Modified;

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

            return place;
        }

        // POST: api/Places
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Location>> PostPlace(Location place)
        {
            _context.Locations.Add(place);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPlace), new { id = place.Id }, place);
        }

        // DELETE: api/Places/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Location>> DeletePlace(int id)
        {
            var place = await _context.Locations.FindAsync(id);
            if (place == null)
            {
                return NotFound();
            }

            _context.Locations.Remove(place);
            await _context.SaveChangesAsync();

            return place;
        }

        private bool PlaceExists(int id)
        {
            return _context.Locations.Any(e => e.Id == id);
        }
    }
}
