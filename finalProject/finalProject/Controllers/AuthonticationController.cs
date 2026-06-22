using DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using service;

namespace finalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthonticationController(VolunteerService volunteerService , JwtService jwtService): ControllerBase
    {
        [HttpPost("login")]

        public IActionResult Login(LoginDTO login)
        {
            var v = volunteerService.ValidatUser(login);
            if(v == null)
            {
                return Unauthorized("Invalid email or password");
            }
            var token = jwtService.GenerateToken(v);
            return Ok(token);
        }

















    }
}
