using System;

namespace KyustendilAPI.Configuration
{
    public class JwtConfig
    {
        /// <summary>
        /// The secret 32 char string that is used to encrypt the api key
        /// </summary>
        public String Secret { get; set; }
    }
}
