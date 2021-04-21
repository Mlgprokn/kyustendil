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
        private readonly MockLocationsRepo _repository = new MockLocationsRepo();

        [HttpGet]
        public ActionResult<IEnumerable<Location>> GetLocations()
        {
            return Ok(_repository.GetLocations());
        }

        [HttpGet("{id}")]
        public ActionResult<Location> GetLocation(int id)
        {
            return Ok(_repository.GetLocation(id));
        }
    }
}
