using LMS.Core.Interfaces;
using LMS.Core.Utilities;
using LMS.Core.Utilities.Responses;
using LMS.Core.Utilities.Responses.DTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Services
{
    public class IAuthenticationServices : IAuthentication
    {
        private readonly ApiSettings _apiSettings;
        private RoleManager<IdentityRole> _roleManager { get; set; }

        public IAuthenticationServices(IOptions<ApiSettings> apiSettings, RoleManager<IdentityRole> roleManager)
        {
            _apiSettings = apiSettings.Value;
            _roleManager = roleManager;
        }

        public async Task<AuthenticationResponse> jwtToken(LoginDTO user)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_apiSettings.Key));
            double tokenExpiryTime = Convert.ToDouble(_apiSettings.TokenExpireTime);
            var Expires = DateTime.UtcNow.AddHours(tokenExpiryTime);
            var tokenHandler = new JwtSecurityTokenHandler();
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            //var findRole = await _roleManager.FindByNameAsync(user.Role);
            // var defaultRole = user.Role;


            var claims = new[]
            {
                new Claim("userId", user.Id),
                new Claim("email", user.UserName),
                new Claim("phoneNumber", user.PhoneNumber),
                new Claim("firstName", user.FirstName),
                new Claim("lastName", user.LastName),
                new Claim("middleName", user.MiddleName),
                new Claim("host", "edurexLMS"),
                new Claim("defaultRole", user.Role),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            JwtSecurityToken token = new JwtSecurityToken(
                issuer: _apiSettings.Issuer,
                audience: _apiSettings.Audience,
                claims: claims,
                expires: Expires,
                signingCredentials: creds);

            //var KYCMethods = new List<string>
            //{
            //    user.EmailConfirmed == true ? "Email": String.Empty,
            //    user.PhoneNumberConfirmed == true ? "Phone": String.Empty
            //};
            //KYCMethods.RemoveAll(s => s == String.Empty);

            return new AuthenticationResponse
            {
                Token = tokenHandler.WriteToken(token),
                IsAuthenticated = true,
                Email = user.Email,
                Role = user.Role,
                TokenExpiration = Expires,
                Message = ResponseMessages.APPROVED,
                UserName = user.UserName,
                RefreshToken = ""
            };
            var ho = "";
        }
    }
}
