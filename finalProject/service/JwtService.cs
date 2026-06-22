using entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public class JwtService(IConfiguration configuration)
    {
        public string GenerateToken(Volunteer volunteer)
        {
            var Claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, volunteer.Id.ToString()),
                new Claim(ClaimTypes.Name, $"{volunteer.FullName}"),
                new Claim(ClaimTypes.Email,volunteer.EmailAddress)
            };

            var secretKey = configuration["Jwt:SecretKey"];
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: configuration["Jwt:Issuer"],
                audience: configuration["Jwt:Audience"],
                claims: Claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
