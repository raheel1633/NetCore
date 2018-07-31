using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using LFSCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using NetCore.API.Data;
using NetCore.API.Dtos;

namespace NetCore.API.Controllers {
    [Route ("api/[controller]")]
    //[ApiController]
    public class AuthController : ControllerBase {
        private readonly IAuthRepository _repo;
        private readonly IConfiguration _config;
        public AuthController (IAuthRepository repo, IConfiguration config) {
            _config = config;
            _repo = repo;
        }

        [HttpPost ("register")]
        public async Task<IActionResult> Register ([FromBody] UserForRegisterDto userDTO) {

            if (!ModelState.IsValid)
                return BadRequest (ModelState);

            userDTO.username = userDTO.username.ToLower ();

            if (await _repo.UserExist (userDTO.username))
                return BadRequest ("User already exists");

            var usertocreate = new User {
                Username = userDTO.username,
                Email = userDTO.email,

            };

            var usercreated = await _repo.Register (usertocreate, userDTO.password);

            return StatusCode (201);

        }

        //[AllowAnonymous]        
        [HttpPost ("login")]
        public async Task<IActionResult> Login ([FromBody] UserForLoginDto userDto) {
            
            //throw new Exception("Exception from auth controller api");

            if (!ModelState.IsValid)
                return BadRequest (ModelState);

            var userlogin = await _repo.Login (userDto.Username.ToLower(), userDto.Password);

            if (userlogin == null)
                return Unauthorized ();

            var claims = new [] {
                new Claim (ClaimTypes.NameIdentifier, userlogin.UserId.ToString ()),
                new Claim (ClaimTypes.Name, userlogin.Username)
            };

            var key = new SymmetricSecurityKey (Encoding.UTF8
             .GetBytes (_config.GetSection("AppSettings:Token").Value));

             var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

             var tokenDescriptor = new SecurityTokenDescriptor{

                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
             };

             var tokenHandler = new JwtSecurityTokenHandler();

             var token = tokenHandler.CreateToken(tokenDescriptor);

             return Ok(new {

                 token = tokenHandler.WriteToken(token)

             });

        }

    }
}