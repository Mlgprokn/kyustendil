﻿using KyustendilAPI.Configuration;
using KyustendilAPI.Models.DTOs.Requests;
using KyustendilAPI.Models.DTOs.Responses;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace KyustendilAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        /// <summary>
        /// The user manager instance
        /// </summary>
        private readonly UserManager<IdentityUser> _userManager;

        /// <summary>
        /// The jwt configuration instance
        /// </summary>
        private readonly JwtConfig _jwtConfig;

        /// <summary>
        /// Base Constuctor
        /// </summary>
        public AuthenticationController(
            UserManager<IdentityUser> userManager,
            IOptionsMonitor<JwtConfig> optionsMonitor)
        {
            _userManager = userManager;
            _jwtConfig = optionsMonitor.CurrentValue;
        }

        /// <summary>
        /// Register a user
        /// </summary>
        /// <param name="user">UserRegistrationDto object</param>
        /// <returns>Json resposce with information aboth the register</returns>
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] UserRegistrationDto user)
        {
            //Check if the data is valid
            if (!ModelState.IsValid)
                return BadRequest(new RegistrationResponse()
                {
                    Errors = new List<string>() { "Invalid data" },
                    Success = false
                });

            //Check if user with this email exists
            var existingUser = await _userManager.FindByEmailAsync(user.Email);
            if (existingUser != null)
                return BadRequest(new RegistrationResponse()
                {
                    Errors = new List<string>() { "User with this email already exists" },
                    Success = false
                });

            //Create the new user
            var newUser = new IdentityUser() { Email = user.Email, UserName = user.Email, };
            var isCreated = await _userManager.CreateAsync(newUser, user.Password);

            //Check if the user creation is successful
            if (!isCreated.Succeeded)
                return BadRequest(new RegistrationResponse()
                {
                    Errors = isCreated.Errors.Select(x => x.Description).ToList(),
                    Success = false
                });

            var jwtToken = GenerateJwtToken(newUser);
            return Ok(new RegistrationResponse()
            {
                Success = true,
                Token = jwtToken
            });
        }

        /// <summary>
        /// Login a user
        /// </summary>
        /// <param name="user">UserLoginDto object</param>
        /// <returns>Json resposce with information aboth the login</returns>
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDto user)
        {
            //Check if the data is valid
            if (!ModelState.IsValid)
                return BadRequest(new RegistrationResponse()
                {
                    Errors = new List<string>() { "Invalid data" },
                    Success = false
                });

            //Check if user with this email exists
            var existingUser = await _userManager.FindByEmailAsync(user.Email);
            if (existingUser == null)
                return BadRequest(new RegistrationResponse()
                {
                    Errors = new List<string>() { "Invalid login" },
                    Success = false
                });

            //Login the user
            var isCorrect = await _userManager.CheckPasswordAsync(existingUser, user.Password);

            if (!isCorrect)
                return BadRequest(new RegistrationResponse()
                {
                    Errors = new List<string>() { "Password is not correct" },
                    Success = false
                });

            var jwtToken = GenerateJwtToken(existingUser);
            return Ok(new RegistrationResponse()
            {
                Success = true,
                Token = jwtToken
            });
        }

        /// <summary>
        /// Generates the jwt token
        /// </summary>
        /// <param name="user">The user</param>
        /// <returns>The generated jwt token</returns>
        private string GenerateJwtToken(IdentityUser user)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtConfig.Secret);

            var tokenDescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("Id", user.Id),
                    new Claim(JwtRegisteredClaimNames.Email, user.Email),
                    new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                }),
                Expires = DateTime.UtcNow.AddHours(6),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = jwtTokenHandler.CreateToken(tokenDescription);
            return jwtTokenHandler.WriteToken(token);   
        }
    }
}
