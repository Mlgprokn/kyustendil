using kyustendil.Data;
using kyustendil.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kyustendil.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        /// <summary>
        /// Repository
        /// </summary>
        private readonly ILocationsRepo _repository;

        /// <summary>
        /// Constructor
        /// </summary>
        public LocationsController(ILocationsRepo repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Gets all locations from the database
        /// </summary>
        /// <returns>Json file containing all locations</returns>
        [HttpGet]
        public ActionResult<IEnumerable<Location>> GetLocations()
        {
            return Ok(_repository.GetLocations());
        }

        /// <summary>
        /// Gets single location from the database
        /// </summary>
        /// <param name="id">The id of the location</param>
        /// <returns>Json file containing the location</returns>
        [HttpGet("{id}")]
        public ActionResult<Location> GetLocation(int id)
        {
            return Ok(_repository.GetLocation(id));
        }
    }
}
