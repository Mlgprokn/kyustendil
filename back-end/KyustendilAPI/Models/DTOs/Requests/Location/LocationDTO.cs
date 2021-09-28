using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KyustendilAPI.Models.DTOs.Requests.Location
{
    /// <summary>
    /// The location dto
    /// </summary>
    public class LocationDTO
    {
        /// <summary>
        /// Unique id of the place
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The title of the place
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Picture of the place
        /// </summary>
        [Required]
        public string Picture { get; set; }

        /// <summary>
        /// The location on which the place can be found
        /// </summary>
        public string Information { get; set; }

        /// <summary>
        /// The latitude of the location
        /// </summary>
        [Required]
        public int Lat { get; set; }

        /// <summary>
        /// The longitude of the location
        /// </summary>
        [Required]
        public int Lgn { get; set; }
    }
}
