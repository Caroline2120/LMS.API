using LMS.Core.Enums;
using LMS.Core.Interfaces;
using LMS.Core.Models.Enrollment;
using LMS.Core.Utilities;
using LMS.Core.Utilities.Responses;
using LMS.Core.Utilities.Responses.DTO;
using LMS.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain.Services
{
    public class IUserService : IUsers
    {
        private readonly EdurexDbContext _edurexDbContext;
        private readonly UserManager<Users> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IADIN_APIs _adinAPIs;
        private readonly IAuthentication _authentication;

        public IUserService(IAuthentication authentication, IADIN_APIs adinAPIs, EdurexDbContext edurexDbContext, UserManager<Users> userManager, RoleManager<IdentityRole> roleManager)
        {
            _edurexDbContext = edurexDbContext;
            _userManager = userManager;
            _roleManager = roleManager;
            _adinAPIs = adinAPIs;
            _authentication = authentication;
        }

        public async Task<APIResponses<AuthenticationResponse>> Login(string Email, string Password)
        {
            // Check for user's details in EDUREX DB
            //--------------------------------------
            var EdurexDb = await _userManager.Users.Where(x => x.Email == Email).FirstOrDefaultAsync();

            if(EdurexDb == null)
            {
                // Check for user's details in ADIN API
                //--------------------------------------
                var response1 = await _adinAPIs.GetStudentByEmail(Email);
                if(response1.Item1 == null)
                {
                    return new APIResponses<AuthenticationResponse>(null, response1.Item2, false, ResponseMessages.INVALID_USER);
                }
                else
                {
                   var response = response1.Item1;

                    var currentUser = new LoginDTO
                    {
                        Email = response.Email,
                        FirstName = response.Firstname,
                        Id = response.StudentId,
                        LastName = response.Surname,
                        MiddleName = response.Othernames,
                        PhoneNumber = response.Phone,
                        Role = "Student",
                        UserName = response.MatricNo
                    };

                    var result =await _authentication.jwtToken(currentUser);

                    return new APIResponses<AuthenticationResponse>(result, System.Net.HttpStatusCode.OK, true);
                }

            }
            else
            {
                if (await _userManager.CheckPasswordAsync(EdurexDb, Password))
                {
                    var dRole = await _roleManager.FindByIdAsync(EdurexDb.DefaultRole);
                    var currentUser = new LoginDTO
                    {
                        Email = EdurexDb.Email,
                        FirstName = EdurexDb.FirstName,
                        Id = EdurexDb.StudentNumber,
                        LastName = EdurexDb.LastName,
                        MiddleName = EdurexDb.MiddleName,
                        PhoneNumber = EdurexDb.PhoneNumber,
                        Role = dRole.Name,
                        UserName = EdurexDb.UserName
                    };

                    var result = await _authentication.jwtToken(currentUser);


                    return new APIResponses<AuthenticationResponse>(result, System.Net.HttpStatusCode.OK, true);
                }

                return new APIResponses<AuthenticationResponse>(null, System.Net.HttpStatusCode.NotFound, false, ResponseMessages.WRONG_PASSWORD);
            }
        }
    }
}
