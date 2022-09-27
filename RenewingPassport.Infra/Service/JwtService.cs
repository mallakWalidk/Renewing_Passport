using Microsoft.IdentityModel.Tokens;
using RenewingPassport.Core.DTO;
using RenewingPassport.Core.Repository;
using RenewingPassport.Core.Service;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RenewingPassport.Infra.Service
{
    public class JwtService : IJwtService
    {
        private readonly IJwtRepository jwtRepository;

        public JwtService(IJwtRepository _jwtRepository)
        {
            jwtRepository = _jwtRepository;
        }

        public string Auth(LoginDTO login)
        {
            var result = jwtRepository.Auth(login);
            if (result == null)
                return null;
            else
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.ASCII.GetBytes("[Hamza Key should be long]");//(Public Key)You can use any thing here(String)
                var tokenDiscriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.Sid,result.UserId.ToString()),
                        new Claim(ClaimTypes.Name,result.UserName),
                        new Claim(ClaimTypes.Role,result.RoleName),
                        new Claim(ClaimTypes.GivenName,result.FullName),
                    }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey),
                    SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDiscriptor);
                return tokenHandler.WriteToken(token);
            }
        }
    }
}