using System;
using System.Collections.Generic;

namespace KyustendilAPI.Configuration
{
    public class AuthResult
    {
        /// <summary>
        /// The token for the authentication
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Whether the authentication is successful
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// The errors that occured during the authentication
        /// </summary>
        public List<String> Errors { get; set; }
    }
}
