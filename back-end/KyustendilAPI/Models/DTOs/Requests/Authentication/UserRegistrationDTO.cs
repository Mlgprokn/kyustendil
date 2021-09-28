using System;
using System.ComponentModel.DataAnnotations;

namespace KyustendilAPI.Models.DTOs.Requests
{
    public class UserRegistrationDTO
    {
        /// <summary>
        /// The registration email
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// The registration password
        /// </summary>
        [Required]
        public string Password { get; set; }
    }
}
