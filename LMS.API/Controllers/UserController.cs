using LMS.Core.Utilities.Responses;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System;
using LMS.Core.Interfaces;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using LMS.Core.Utilities.Requests;

namespace LMS.API.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    [Route("api/v1/[controller]")]
    
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUsers _user;
        public UserController(ILogger<UserController> logger, IUsers user)
        {
            _logger = logger;
            _user = user;
        }




        /// <summary>
        /// Login
        /// </summary>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Not Found</response>
        /// <response code="500">Internal Server Error</response>
        /// <param name="Email"></param>
        /// <returns></returns>
        [ProducesResponseType(typeof(APIResponses<AuthenticationResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(APIErrorResponseList), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(APIErrorResponseList), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(APIErrorResponseList), StatusCodes.Status500InternalServerError)]
        [HttpPost("Login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginDto dto)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return BadRequest(new APIErrorResponseList(new string[] { ModelState.ToString() }, HttpStatusCode.NotFound, false));
                }
                var result = await _user.Login(dto.Email, dto.Password);
                if(result.status == HttpStatusCode.NotFound && result.message != null)
                {
                    return BadRequest(new APIErrorResponseList(new string[] { result.message }, HttpStatusCode.NotFound, false));
                }
                return Ok(result);
            }
            catch (ArgumentException argex)
            {
                return BadRequest(new APIErrorResponseList(new string[] { argex.Message }, HttpStatusCode.BadRequest, false));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
