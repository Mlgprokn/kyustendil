using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KyustendilAPI.Models.DTOs.Requests
{
    public class UserLoginDTO
    {
        /// <summary>
        /// The login email
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// The login password
        /// </summary>
        [Required]
        public string Password { get; set; }
    }
}
