﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KyustendilAPI.Models
{
    /// <summary>
    /// Place model
    /// </summary>
    public class Location
    {
        /// <summary>
        /// Unique id of the place
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The title of the place
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Description of the place
        /// </summary>
        public string Picture { get; set; }

        /// <summary>
        /// The location on which the place can be found
        /// </summary>
        public string Information { get; set; }
    }
}
